using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class MapsController : Controller
    {
        AddressManager addressManager = new AddressManager(new EfAddressDal());
        // GET: Dashboard/Maps
        public ActionResult Index()
        {
            return View(addressManager.First());
        }
    }
}