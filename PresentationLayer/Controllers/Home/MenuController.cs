using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Home
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuDal());
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult List()
        {
            var list = menuManager.List();
            return PartialView(list);
        }

        public PartialViewResult TopRated()
        {
            var list = menuManager.ListTopRated();
            return PartialView(list);
        }
    }
}