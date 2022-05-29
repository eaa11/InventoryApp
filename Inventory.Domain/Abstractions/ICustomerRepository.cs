using Inventory.Models.Domain;

namespace Inventory.Domain.Abstractions
{
    public interface ICustomerRepository
    {
        // Define methods to the Customer repository

        Task<List<Customer>> GetCustomersAsync();
        Task<bool> AddCustomer(Customer customer);

    }
}
