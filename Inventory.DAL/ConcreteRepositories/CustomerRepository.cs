using Inventory.DAL.Context;
using Inventory.Domain.Abstractions;
using Inventory.Domain.Models;

namespace Inventory.DAL.ConcreteRepositories
{
    public class CustomerRepository : CommonRepository, ICustomerRepository
    {
        public CustomerRepository(InventoryDbContext inventoryDbContext) : base(inventoryDbContext)
        {
        }


        // Implements methods to the Customer repository

        public async Task<bool> AddCustomer(Customer customer)
        {
             _inventoryDbContext.Customers?.Add(customer);

            return await _inventoryDbContext.SaveChangesAsync() > 0;
        }
    }
}
