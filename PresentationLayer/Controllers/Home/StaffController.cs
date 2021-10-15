using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.Home
{
    public class StaffController : Controller
    {
        StaffManager staffManager = new StaffManager(new EfStaffDal());
        // GET: _PartialStaff
        public PartialViewResult Index()
        {
            var list = staffManager.List();
            return PartialView(list);
        }
    }
}