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
    public class AddressController : Controller
    {
        AddressManager addressManager = new AddressManager(new EfAddressDal());
        // GET: Address
        public PartialViewResult Index()
        {
            var first = addressManager.First();
            return PartialView(first);
        }

        [HttpPost]
        public ActionResult Edit(Address p)
        {
            addressManager.Add(p);
            return RedirectToAction("Index");
        }
    }
}