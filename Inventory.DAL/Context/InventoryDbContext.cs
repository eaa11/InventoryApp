using Inventory.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DAL.Context
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Customer>? Customers { get; set; }
        public virtual DbSet<Product>? Products { get; set; }
    }
}
