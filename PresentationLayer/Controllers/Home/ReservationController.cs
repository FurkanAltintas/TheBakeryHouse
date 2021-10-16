using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Home
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        EventManager eventManager = new EventManager(new EfEventDal());
        // GET: _PartialReservation
        public ActionResult Index()
        {
            ViewBag.Success = TempData["Reservation"] as string;
            Event();
            return View();
        }

        [HttpGet]
        public PartialViewResult Add()
        {
            Event();
            return PartialView();
        }

        [HttpPost]
        public ActionResult Add(Reservation p)
        {
            reservationManager.Add(p);
            TempData["Reservation"] = "Reservation";
            return RedirectToAction("Index", "Reservation");
        }

        public void Event()
        {
            ViewBag.Event = new SelectList(eventManager.List(), "Id", "Name");
        }
    }
}