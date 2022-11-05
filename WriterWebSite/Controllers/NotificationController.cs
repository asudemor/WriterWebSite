using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterWebSite.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Notification()
        {
            return View();
        }
    }
}
