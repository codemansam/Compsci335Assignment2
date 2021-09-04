using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Compsci335Assignment2.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Compsci335Assignment2.Handler
{
    public class MyAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IWebApiRepo _repo;
        public MyAuthHandler(
            IWebApiRepo repository,  // We need to add this reference to the database.  The remaining parameters we don't do anything with but are necessary
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger, 
            UrlEncoder encoder, 
            ISystemClock clock) 
            : base(options, logger, encoder, clock)
        {
            _repo = repository;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                Response.Headers.Add("WWW-Authenticate", "Basic");
                return AuthenticateResult.Fail("Authorization header not found.");
            }
            else
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]); // gets the base64 encoding of "username:password"
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter); //decodes base64 string to UTF8 bytes representing characters
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(":"); // makes array with the decoded username and password split on : 
                var username = credentials[0];
                var password = credentials[1];
                if (_repo.ValidLogin(username, password))
                {
                    var claims = new[] { new Claim("userName", username) };  // User is valid so we begin making a ticket

                    ClaimsIdentity identity = new ClaimsIdentity(claims, "Basic");
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    AuthenticationTicket ticket = new AuthenticationTicket(principal, Scheme.Name);  // Scheme is a property of the handler class. This is made in Startup when we register
                                                                                                    // the service.  In this case we called it "MyAuthentication"

                    return AuthenticateResult.Success(ticket);  // Ticket returns to context 
                }

                else
                {
                    return AuthenticateResult.Fail("userName and password do not match.");
                }
            }

           
        }
    }
}
