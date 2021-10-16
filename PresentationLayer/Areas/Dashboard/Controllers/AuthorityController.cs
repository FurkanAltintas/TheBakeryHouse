using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class AuthorityController : Controller
    {
        AuthorityManager authorityManager = new AuthorityManager(new EfAuthorityDal());
        // GET: Dashboard/Authority
        public ActionResult Index()
        {
            return View(authorityManager.List());
        }
    }
}