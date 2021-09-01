using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Models;

namespace Compsci335Assignment2.Data
{
    public class AuthRepo : IauthRepo
    {
        private readonly WebAPIDBContext _dbContext;

        public AuthRepo(WebAPIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ValidLogin(string userName, string password)
        {
            User u = _dbContext.Users.FirstOrDefault(e => e.UserName == userName && e.Password == password);
            if (c == null)
            {
                return false;
            }

            return true;
        }
    }

}