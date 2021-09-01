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

        public User GetUser(string userName)
        {
            var result = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
            return result;
        }

        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = _dbContext.Users.ToList();
            return result;

        }
    }
}
