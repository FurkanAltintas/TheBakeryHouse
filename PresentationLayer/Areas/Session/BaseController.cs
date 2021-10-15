using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Session
{
    public class BaseController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["Email"] != null)
            {
                Email = (string)Session["Email"];
                var user = employeeManager.Find(Email);
                Id = user.Id;
                Name = user.FullName;
                Image = user.Profile;
            }
            else
            {

            }
            base.OnActionExecuting(filterContext);
        }
    }
}