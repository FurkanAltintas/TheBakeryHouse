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
    public class AddressesController : Controller
    {
        AddressManager addressManager = new AddressManager(new EfAddressDal());
        // GET: Dashboard/Address
        public ActionResult Index()
        {
            return View(addressManager.First());
        }

        [HttpPost]
        public ActionResult Edit(Address p)
        {
            addressManager.Update(p);
            return RedirectToAction("Index");
        }
    }
}