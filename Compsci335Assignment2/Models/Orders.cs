using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compsci335Assignment2.Models
{
    public class Order
    {
        [Key] 
        public int Id { get; set; }
        public string UserName { get; set; }
        public int ProductId { get;  set; }
        public int Quantity { get; set; }
    }
}
