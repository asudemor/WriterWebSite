using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriterWebSite.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
