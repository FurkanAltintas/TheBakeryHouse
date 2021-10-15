    using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class ContactsController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        // GET: Dashboard/Contacts
        public ActionResult Index()
        {
            var list = contactManager.List();
            return View(list);
        }

        public ActionResult Delete(int id)
        {
            var key = contactManager.Find(id);
            contactManager.Delete(key);
            return RedirectToAction("Index");
        }

    }
}