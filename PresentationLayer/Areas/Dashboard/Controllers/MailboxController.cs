using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using PresentationLayer.Areas.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Dashboard.Controllers
{
    public class MailboxController : BaseController
    {
        MailManager mailManager = new MailManager(new EfMailDal());
        // GET: Dashboard/Mailbox
        public ActionResult Inbox()
        {
            var list = mailManager.Inbox(Email).OrderByDescending(x => x.History);
            return View(list);
        }

        /* mail/u/0/#starred/urlhash */
        public ActionResult MailRead(string status, int id)
        {
            var list = mailManager.Find(id);
            return View(list);
        }

        //Partial
        public PartialViewResult Compose()
        {
            return PartialView();
        }

        public PartialViewResult UnRead()
        {
            ViewBag.UnRead = mailManager.Inbox(Email).Where(x => x.IsRead == false).Count();
            return PartialView();
        }

    }
}