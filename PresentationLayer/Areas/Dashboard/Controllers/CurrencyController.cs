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
    public class CurrencyController : Controller
    {
        CurrencyManager currencyManager = new CurrencyManager(new EfCurrencyDal());
        // GET: Dashboard/Currency
        public ActionResult Index()
        {
            var list = currencyManager.List();
            return View(list);
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
        public ActionResult Edit(Currency p)
        {
            if (p.Id > 0)
            {
                currencyManager.Update(p);
            }
            else
            {
                currencyManager.Add(p);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            currencyManager.Delete(Find(id));
            return RedirectToAction("Index"); // 55
        }

        public Currency Find(int id)
        {
            return currencyManager.Find(id); //57
        }
    }
}