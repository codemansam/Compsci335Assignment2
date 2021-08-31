using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Compsci335Assignment2.Data
{
    public class WebAPIDBContext : DbContext
    {
        public WebAPIDBContext(DbContextOptions<WebAPIDBContext> options) : base(options) {}
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
