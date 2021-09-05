using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Compsci335Assignment2.Models;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;

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

        public bool ValidLogin(string userName, string password)
        {
            User u = _dbContext.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            if (u == null)
                return false;
            return true;
        }

        public Order ProductOrder(string name, int productId, int quantity)
        {
            Order o = new Order();
            o.UserName = name;
            o.ProductId = productId;
            o.Quantity = quantity;
            _dbContext.Orders.Add(o);
            _dbContext.SaveChanges();
            return o;
        }

        public void OrderOne(string name, int productId)
        {
            Order o = new Order();
            o.UserName = name;
            o.ProductId = productId;
            o.Quantity = 1;
            _dbContext.Orders.Add(o);
            _dbContext.SaveChanges();
        }
    }
}
