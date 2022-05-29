using Inventory.API.Models;

namespace Inventory.API
{
    public class CustomerDataStore
    {
        public List<CustomerDto> Customers { get; set; }
        public static CustomerDataStore Current { get; } = new CustomerDataStore();

        public CustomerDataStore()
        {
            Customers = new List<CustomerDto>()
            {
                new CustomerDto()
                {
                    CustomerId = 1,
                    CustomerName = "Aljandra"
                },
                new CustomerDto()
                {
                    CustomerId = 2,
                    CustomerName = "Estrella"
                },
                new CustomerDto()
                {
                    CustomerId = 3,
                    CustomerName = "Alexa"
                },
            };
        }
    }
}
