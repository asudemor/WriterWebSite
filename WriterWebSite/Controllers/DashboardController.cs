using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterWebSite.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Dashboard()
        {
            Context context = new Context();
            ViewBag.v1 = context.Blogs.Count().ToString();
            ViewBag.v2 = context.Blogs.Where(x=>x.WriterID==1).Count().ToString();
            ViewBag.v3 = context.Categories.Count().ToString();
            return View();
        }
    }
}
