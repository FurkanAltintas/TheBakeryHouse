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
    public class BannersController : Controller
    {
        BannerManager bannerManager = new BannerManager(new EfBannerDal());
        // GET: Dashboard/Banner
        public ActionResult Index()
        {
            return View(bannerManager.First());
        }

        [HttpPost]
        public ActionResult Edit(Banner p)
        {
            bannerManager.Update(p);
            return RedirectToAction("Index");
        }
    }
}