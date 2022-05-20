using Inventory.DAL.Context;
using Inventory.Domain.Abstractions;

namespace Inventory.DAL.ConcreteRepositories
{
    public class ProductRepository : CommonRepository, IProductRepository
    { 
        public ProductRepository(InventoryDbContext inventoryDbContext) : base(inventoryDbContext)
        {
        }

        // Implements methods to the Product Repository 
    }
}
