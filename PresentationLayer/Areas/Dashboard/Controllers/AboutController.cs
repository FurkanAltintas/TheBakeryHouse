using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        // GET: Dashboard/About
        public ActionResult Index()
        {
            return View(aboutManager.First());
        }

        [HttpPost]
        public ActionResult Edit(About p)
        {
            aboutManager.Update(p);
            return RedirectToAction("Index");
        }
    }
}