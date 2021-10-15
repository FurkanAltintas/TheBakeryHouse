using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Home
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Success = TempData["Added"] as string;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact p)
        {
            p.DateTime = DateTime.Now;
            contactManager.Add(p);
            TempData["Added"] = "Added";
            return RedirectToAction("Index");
        }
    }
}