using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Models
{
    public class Product
    {
        // Define Properties
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
    }
}
