namespace Inventory.API.Models
{
    public class CategoryDto
    {
        public ICollection<ProductDto>? Products { get; set; }
    }
}
