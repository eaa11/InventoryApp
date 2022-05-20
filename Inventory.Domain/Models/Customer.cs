using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Models
{
    public class Customer
    {
        // Define Properties
        [Key]
        public int Id { get; set; }
        public string? CustomerName { get; set; }
    }
}
