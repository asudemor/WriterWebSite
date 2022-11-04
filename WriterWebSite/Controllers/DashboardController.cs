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
            return View();
        }
    }
}
