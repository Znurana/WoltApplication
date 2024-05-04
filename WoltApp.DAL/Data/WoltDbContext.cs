using System;
using Microsoft.EntityFrameworkCore;
using WoltApp.DAL.Model;

namespace WoltApp.DAL.Data
{
    public class WoltDbContext : DbContext
    {
        public WoltDbContext(DbContextOptions<WoltDbContext> options) : base(options)
        {

        }

        
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }


    }
}

