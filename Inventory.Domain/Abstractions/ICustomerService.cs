using Inventory.Models.Domain;

namespace Inventory.Domain.Abstractions
{
    public interface ICustomerService
    {
        // Define methods to the Customer services

        Task<List<Customer>> GetCustomersAsync();
        Task<bool> AddCustomer(Customer customer);
    }
}
