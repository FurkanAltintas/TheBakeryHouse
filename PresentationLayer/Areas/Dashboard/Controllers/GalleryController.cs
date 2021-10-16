using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class GalleryController : Controller
    {
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        // GET: Dashboard/Gallery
        public ActionResult Index()
        {
            return View(galleryManager.List());
        }
    }
}