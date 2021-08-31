using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Models;

namespace Compsci335Assignment2.Data
{
    public class DbWebApiRepo : IWebApiRepo
    {
        private readonly WebAPIDBContext _dbContext;

        public DbWebApiRepo(WebAPIDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
