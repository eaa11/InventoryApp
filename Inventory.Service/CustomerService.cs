using Inventory.Domain.Abstractions;
using Inventory.Models.Domain;

namespace Inventory.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        // Implements methods to the Customer service 

        public async Task<bool> AddCustomer(Customer customer) => await _repo.AddCustomer(customer);

        public async Task<List<Customer>> GetCustomersAsync() => await _repo.GetCustomersAsync();
      
    }
}
