using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Microsoft.AspNetCore.Authorization;

namespace Compsci335Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseSingleItemController : ControllerBase
    {
        private readonly IWebApiRepo _webApiRepo;

        public PurchaseSingleItemController(IWebApiRepo webApiRepo)
        {
            _webApiRepo = webApiRepo;
        }

        [Authorize(AuthenticationSchemes = "MyAuthentication")]
        [Authorize(Policy = "UserOnly")]
        [HttpPost]
        public IActionResult Order([FromHeader] string UserName, [FromHeader] int ProductId, [FromHeader] int Quantity = 1)
        {
            return Ok();
        }
    }
}