using Inventory.Domain.Abstractions;

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
    }
}
