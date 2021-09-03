using System;
using System.Collections.Generic;
using System.Linq;
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
            IWebApiRepo repository,  // We need this reference to the database.  The remaining parameters we don't do anything with but are necessary
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
            throw new NotImplementedException();
        }
    }
}
