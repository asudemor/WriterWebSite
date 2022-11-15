using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WriterWebSite.Areas.Admin.Models;

namespace WriterWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        public IActionResult Writer()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public static List<WriterModel> writers = new List<WriterModel>
        {
            new WriterModel
            {
                ID=1,Name="Asude"
            }
        };
        public IActionResult GetWriterByID(int writerId)
        {
            var findWriter = writers.FirstOrDefault(x => x.ID == writerId);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }
        [HttpPost]
        public IActionResult AddWriter(WriterModel writer)
        {
            writers.Add(writer);
            var jsonWriters = JsonConvert.SerializeObject(writer);
            return Json(jsonWriters);
        }
    }
}
