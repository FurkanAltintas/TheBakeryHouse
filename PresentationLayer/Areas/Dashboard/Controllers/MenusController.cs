using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class MenusController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuDal(), new EfCurrencyDal());
        // GET: Dashboard/Menu
        public ActionResult Index()
        {
            var list = menuManager.List();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Currency();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Menu p)
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
                var fileName = Path.GetFileName(file.FileName);
                var path = Server.MapPath("~/Images/Menu/");
                var url = "/Images/Menu" + fileName;
                var pathWithfileName = Path.Combine(path, fileName);
                file.SaveAs(pathWithfileName);
                p.Image = url;
                p.IsTopRated = false;
                menuManager.Add(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Currency();
            var key = Find(id);
            return View(key);
        }

        [HttpPost]
        public ActionResult Edit(Menu p)
        {
            menuManager.Update(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var key = Find(id);
            menuManager.Delete(key);
            return RedirectToAction("Index");
        }

        public ActionResult Rated(int id)
        {
            var key = Find(id);

            if (key.IsTopRated == true)
            {
                key.IsTopRated = false;
            }
            else
            {
                key.IsTopRated = true;
            }
            menuManager.Update(key);
            return RedirectToAction("Index");
        }

        public Menu Find(int id)
        {
            return menuManager.Find(id);
        }

        public void Currency()
        {
            ViewBag.Currency = new SelectList(menuManager.ListCurrency(), "Id", "Name");
        }
    }
}