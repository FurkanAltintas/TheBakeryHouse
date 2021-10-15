using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        // GET: Dashboard/Employee
        public ActionResult Index()
        {
            var list = employeeManager.List();
            return View(list);
        }
    }
}