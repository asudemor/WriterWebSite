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
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubsribeMail()
        {
            return PartialView();
        }
    
        [HttpPost]
        public IActionResult SubsribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nlm.AddNewsLetter(newsLetter);
            return PartialView();
        }
    }
}
