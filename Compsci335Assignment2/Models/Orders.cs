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
        public int id { get; set; }
        public string userName { get; set; }
        public int productId { get;  set; }
        public int quantity { get; set; }
    }
}
