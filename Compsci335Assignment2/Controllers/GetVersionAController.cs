using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Compsci335Assignment2.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Server.HttpSys;

namespace Compsci335Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetVersionAController : ControllerBase
    {
        private readonly IWebApiRepo _webApiRepo;

        public GetVersionAController(IWebApiRepo webApiRepo)
        {
            _webApiRepo = webApiRepo;
        }

        [Authorize(AuthenticationSchemes = "MyAuthentication")]
        [Authorize(Policy = "UserOnly")]
        [HttpGet("ValidLogin")]

        public IActionResult GetVersion()
        {
            return new OkObjectResult("v1");
        }
    }
}
