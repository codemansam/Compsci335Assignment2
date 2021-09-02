using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Compsci335Assignment2.Models;

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
        
        [HttpPost]
        public IActionResult ValidLogin()
        {
            return Ok();

        }

    }
}
