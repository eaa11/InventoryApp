 namespace Inventory.API.Models
{
    public class CustomerDto
    {
        public int? CustomerId { get; set; } // Customer Identification -> Cedula)

        public string? CustomerName { get; set; } = string.Empty;

        public ICollection<ProductDto> ProductOfInterest { get; set; }

        public int NumberOfProductOfInterest 
        { 
            get
            {
                return NumberOfProductOfInterest == 0 ? 0 : ProductOfInterest.Count;
            }
        }

        public CustomerDto() => ProductOfInterest = new List<ProductDto>();

    }
}
