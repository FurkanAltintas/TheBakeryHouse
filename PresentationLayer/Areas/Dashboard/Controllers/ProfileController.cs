using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using PresentationLayer.Areas.Session;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class ProfileController : BaseController
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        // GET: Profile
        public ActionResult Index()
        {
            var profile = employeeManager.Find(Email);
            return View(profile);
        }

        [HttpPost]
        public ActionResult Edit(Employee p)
        {
            string folderPath = Server.MapPath("~/Images/Menu/");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var file = Request.Files[0];
            int MaxContentLength = 1024 * 1024 * 10; //10 MB
            string expansion = Path.GetExtension(file.FileName);
            string[] AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".png", ".gif" };

            if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
            {
                //uzantı problemi
            }
            else if (file.ContentLength > MaxContentLength)
            {
                //dosya boyut problemi
            }
            else
            {
                var user = Find(Email);
                var filePath = Server.MapPath("~" + user.Profile);

                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath); //görsel silme
                }

                var fileName = Path.GetFileName(file.FileName); //klasöre ekleme
                var path = Server.MapPath("~/Images/Employee/");
                var url = "/Images/Employee/" + fileName;
                var pathWithfileName = Path.Combine(path, fileName);
                file.SaveAs(pathWithfileName);
                p.AuthorityId = user.AuthorityId;
                p.Id = user.Id;
                p.Profile = url;
                employeeManager.Update(p);
            }
            return RedirectToAction("Index");
        }

        public Employee Find(string email)
        {
            return employeeManager.Find(Email);
        }
    }
}