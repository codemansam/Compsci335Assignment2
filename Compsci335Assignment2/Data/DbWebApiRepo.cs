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
        // so need to take user handed in.  See if it exists in the database.  So should
        public User Register(User user) //actual method implemented here
        {
            throw new NotImplementedException();
        }
    }
}
