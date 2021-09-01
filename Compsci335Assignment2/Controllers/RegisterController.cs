using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Compsci335Assignment2.Models;

namespace Compsci335Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IWebApiRepo _webApiRepo;

        public RegisterController(IWebApiRepo webApiRepo)
        {
            _webApiRepo = webApiRepo;
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (_webApiRepo.GetUser(user.UserName) != null)
            {
                return Ok("Username not available.");
            };
            _webApiRepo.AddUser(user);
            
            return Ok("User successfully registered.");
        }
    }

}
