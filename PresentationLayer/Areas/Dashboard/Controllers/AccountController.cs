using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        // GET: Dashboard/Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee p)
        {
            if (employeeManager.Login(p))
            {
                FormsAuthentication.SetAuthCookie(p.Email, false);
                Session["Email"] = p.Email;
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                ViewBag.Error = "Your email or password is incorrect";
                return View(p);
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
    }
}