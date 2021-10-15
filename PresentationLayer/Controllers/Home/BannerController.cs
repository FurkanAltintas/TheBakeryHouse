using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Home
{
    public class BannerController : Controller
    {
        BannerManager bannerManager = new BannerManager(new EfBannerDal());
        // GET: _PartialBanner
        public PartialViewResult Index()
        {
            var first = bannerManager.First();
            return PartialView(first);
        }
    }
}