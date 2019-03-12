using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string Get([FromQuery] TestModel model)
        {
            return "value";
        }

        [HttpGet]
        [Route("Workaround")]
        public string Workaround([FromQuery] TestModel2 model)
        {
            return "value";
        }
    }
}
