
using OrderAPI.Models.Entities;

using Microsoft.EntityFrameworkCore;

namespace OrderAPI.Models.Context
{
    public class OrderApiDbContext : DbContext
    {
        public OrderApiDbContext(DbContextOptions options) : base(options) { }

      

        public DbSet<Order> Orders { get; set; }    
        public DbSet<OrderItem> OrderItems { get; set; }    
    }
}
