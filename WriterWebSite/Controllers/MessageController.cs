using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterWebSite.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager m2m = new Message2Manager(new EfMessage2Repository());

        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 1;
            var values = m2m.GetInboxListByWriter(id);
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult MessageDetails(int id)
        {
            var value = m2m.TGetByID(id);
            return View(value);
        }
    }
}
