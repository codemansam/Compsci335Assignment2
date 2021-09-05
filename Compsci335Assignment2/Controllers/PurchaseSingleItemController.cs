using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Compsci335Assignment2.Dtos;
using Compsci335Assignment2.Models;
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
        [HttpGet, Route("{id}")]
        public IActionResult Order(int id)
        {
            var claims = Request.HttpContext.User.Identities.First().Claims.ToList();
            var username = claims.FirstOrDefault(x => x.Type.Equals("userName", StringComparison.OrdinalIgnoreCase))?.Value;

            Order order = _webApiRepo.OrderOne(username,id);
            Response.StatusCode = (int)HttpStatusCode.Created;
            return new JsonResult(order);
        }
    }
}