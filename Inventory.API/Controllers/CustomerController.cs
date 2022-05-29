using Inventory.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController:ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> GetCustomers()
        {
            return Ok(CustomerDataStore.Current.Customers);
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerDto> GetCustomer(int id)
        {
            var customerToReturn = CustomerDataStore.Current.Customers
                .FirstOrDefault(c => c.CustomerId == id);

            return customerToReturn == null? NotFound() : Ok(customerToReturn);
        }
    }
}
