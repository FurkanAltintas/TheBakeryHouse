using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class CalendarController : Controller
    {
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        // GET: Dashboard/Calendar
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Events()
        {
            return Json(reservationManager.ListCalendar(), JsonRequestBehavior.AllowGet);
        }
    }
}