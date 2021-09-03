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
        public MyAuthHandler(DbWebApiRepo repository,
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger, 
            UrlEncoder encoder, 
            ISystemClock clock) 
            : base(options, logger, encoder, clock)
        {
            _repo = repository;
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
