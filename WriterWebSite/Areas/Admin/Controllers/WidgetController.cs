using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class WidgetController : Controller
    {
        public IActionResult Widget()
        {
            return View();
        }
    }
}
