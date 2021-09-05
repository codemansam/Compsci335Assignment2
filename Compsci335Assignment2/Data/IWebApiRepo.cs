using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Dtos;
using Compsci335Assignment2.Models;

namespace Compsci335Assignment2.Data

//Endpoint 4: Purchase a single item. 
// Name this APi PurchaseSingleItem
// specify a ProductID.  This one has Quantity set to 1 by default.
// Implement using Get method

{
    public interface IWebApiRepo
    {
        User GetUser(string userName);
        void AddUser(User user);
        IEnumerable<User> GetAllUsers();
        public bool ValidLogin(string userName, string password);
        // void Order(string name, int productId, int quantity);
        public Order ProductOrder(string name, int productId, int quantity);
        void OrderOne(string name, int productId);
    }
}
 