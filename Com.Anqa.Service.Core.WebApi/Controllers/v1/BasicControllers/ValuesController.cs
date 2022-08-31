using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.Anqa.Service.Core.Lib;
using Microsoft.EntityFrameworkCore;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.Lib.Models;
using Microsoft.AspNetCore.Authorization;

namespace Com.Anqa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/values")]
    [Authorize]
    public class ValuesController : Controller
    {
        public ValuesController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(User.Identity.Name);
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
