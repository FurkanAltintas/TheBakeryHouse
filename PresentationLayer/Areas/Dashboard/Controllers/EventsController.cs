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
    public class EventsController : Controller
    {
        EventManager eventManager = new EventManager(new EfEventDal());
        // GET: Dashboard/Events
        public ActionResult Index()
        {
            var list = eventManager.List();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event p)
        {
            p.CreateDate = DateTime.Now;
            eventManager.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var key = Find(id);
            key.IsActive = true;
            return View(key);
        }

        [HttpPost]
        public ActionResult Edit(int id, Event p)
        {
            eventManager.Update(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var key = Find(id);
            key.IsActive = false;
            return RedirectToAction("Index");
        }

        public Event Find(int id)
        {
            return eventManager.Find(id);
        }
    }
}