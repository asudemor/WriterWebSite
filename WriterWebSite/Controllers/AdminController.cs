using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WriterWebSite.Models;

namespace WriterWebSite.Controllers
{
    public class AdminController : Controller
    {
        //AdminManager wm = new AdminManager(new EfAdminRepository());
        Context context = new Context();

        [Authorize]
        public IActionResult Admin()
        {
            var usermail = User.Identity.Name;
            ViewBag.UserMail = usermail;
            Context context = new Context();
            var writername = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.WriterName = writername;
            return View();
        }

        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}
