using Inventory.Domain.Models;

namespace Inventory.Domain.Abstractions
{
    public interface ICustomerService
    {
        // Define methods to the Customer services

        Task<List<Customer>> GetCustomersAsync();
        Task<bool> AddCustomer(Customer customer);
    }
}
