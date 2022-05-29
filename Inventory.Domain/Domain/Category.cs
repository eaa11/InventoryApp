using Inventory.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models.Domain
{
    public class Category: BaseEntity
    {
        [Required]
        [StringLength(12)]
        [Column("Category Namr")]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
