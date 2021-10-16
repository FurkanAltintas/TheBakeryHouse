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
    [Authorize(Roles = "Yönetici")]
    public class AuthorityController : Controller
    {
        AuthorityManager authorityManager = new AuthorityManager(new EfAuthorityDal());
        // GET: Dashboard/Authority
        public ActionResult Index()
        {
            return View(authorityManager.List());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Authority p)
        {
            if (p.Id > 0)
                authorityManager.Update(p);
            {
                authorityManager.Add(p);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var key = Find(id);
            authorityManager.Delete(key);
            return RedirectToAction("Index");
        }

        public Authority Find(int id)
        {
            return authorityManager.Find(id);
        }
    }
}