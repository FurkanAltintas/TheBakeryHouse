using EntityLayer.Concrete;
using EntityLayer.Dto;
using PresentationLayer.Areas.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class HeaderController : BaseController
    {
        Users users = new Users();
        // GET: Dashboard/Header
        public PartialViewResult Profile()
        {
            return PartialView(User());
        }

        public PartialViewResult Navbar()
        {
            return PartialView(User());
        }

        public Users User()
        {
            users.FullName = Name;
            users.Profile = Image;
            users.Email = Email;
            return users;
        }
    }
}