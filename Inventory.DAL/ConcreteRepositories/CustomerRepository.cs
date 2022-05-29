using Inventory.DAL.Context;
using Inventory.Domain.Abstractions;
using Inventory.Models.Domain;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Customer>> GetCustomersAsync() => await _inventoryDbContext.Customers.ToListAsync();

    }
}
