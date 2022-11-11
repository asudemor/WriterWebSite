using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WriterWebSite.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic3 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
