using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Home
{
    public class GalleryController : Controller
    {
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        // GET: _PartialGallery
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult List()
        {
            var list = galleryManager.List();
            return PartialView(list);
        }
    }
}