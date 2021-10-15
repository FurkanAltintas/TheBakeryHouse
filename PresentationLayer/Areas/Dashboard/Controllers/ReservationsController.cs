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
    public class ReservationsController : Controller
    {
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        EventManager eventManager = new EventManager(new EfEventDal());
        // GET: Dashboard/Reservation
        public ActionResult Index()
        {
            var list = reservationManager.List();
            return View(list);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Event = new SelectList(List(), "Id", "Name");
            var key = Find(id);
            return View(key);
        }

        [HttpPost]
        public ActionResult Edit(int id, Reservation p)
        {
            var key = Find(id);
            reservationManager.Update(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var key = reservationManager.Find(id);
            reservationManager.Delete(key);
            return RedirectToAction("Index");
        }

        public List<Event> List()
        {
            return eventManager.List();
        }

        public Reservation Find(int id)
        {
            return reservationManager.Find(id);
        }
    }
}