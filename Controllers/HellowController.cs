using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace my_first_api_container.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HellowController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "hellow from my first dotnet core container";
        }
    }
}