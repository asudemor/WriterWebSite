using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterWebSite.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager m2m = new Message2Manager(new EfMessage2Repository());
        UserManager um = new UserManager(new EfUserRepository());
        Context context = new Context();
       
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = m2m.GetInboxListByWriter(writerId);
            return View(values);
        }
         
        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = m2m.GetSendBoxListByWriter(writerId);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = m2m.TGetByID(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            //List<SelectListItem> receiverValues = (from x in um.GetList()
            //                                       select new SelectListItem
            //                                       {
            //                                           Text = x.NameSurname,
            //                                           Value = x.Id.ToString()
            //                                       }).ToList();
            //ViewBag.rv = receiverValues;
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 message)
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            message.SenderID = writerId;
            message.ReceiverID = 6;
            message.MessageStatus = true;
            message.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m2m.TAdd(message);
            return RedirectToAction("InBox");
        }
    }
}
