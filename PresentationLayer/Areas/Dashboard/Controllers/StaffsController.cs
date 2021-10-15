using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class StaffsController : Controller
    {
        StaffManager staffManager = new StaffManager(new EfStaffDal());
        // GET: Dashboard/Staffs
        public ActionResult Index()
        {
            var list = staffManager.List();
            return View(list);
        }
    }
}