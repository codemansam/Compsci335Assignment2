using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Compsci335Assignment2.Dtos;
using Compsci335Assignment2.Models;
using Microsoft.AspNetCore.Authorization;

namespace Compsci335Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseItemController : ControllerBase
    {
        private readonly IWebApiRepo _webApiRepo;

        public PurchaseItemController(IWebApiRepo webApiRepo)
        {
            _webApiRepo = webApiRepo;
        }

        [Authorize(AuthenticationSchemes = "MyAuthentication")]
        [Authorize(Policy = "UserOnly")]
        [HttpPost] 
        public IActionResult Order(OrderDto request)
        {
            var claims = Request.HttpContext.User.Identities.First().Claims.ToList();

            var username = claims.FirstOrDefault(x => x.Type.Equals("userName", StringComparison.OrdinalIgnoreCase))?.Value;
            
            Order order = _webApiRepo.ProductOrder(username, request.ProductId, request.Quantity);
            return new OkObjectResult(order);
        }
    }
}
