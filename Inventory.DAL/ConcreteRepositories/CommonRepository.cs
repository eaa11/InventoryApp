using Inventory.DAL.Context;

namespace Inventory.DAL.ConcreteRepositories
{
    public abstract class CommonRepository
    {
        protected readonly InventoryDbContext _inventoryDbContext;
        public CommonRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }
    }
}
