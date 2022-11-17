using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WriteWebSiteApi.DataAccessLayer;

namespace WriteWebSiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var context = new Context();
            var values = context.Employees.ToList();
            return Ok(values);
        }
    }
}
