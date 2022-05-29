using Inventory.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models.Domain
{
    public class Customer : BasicInformation
    {
        [Required]
        [StringLength(12)]
        [Column("CustomerID")]
        public string CustomerId { get; set; } // Customer Identification -> Cedula)


        [Required]
        [StringLength(100)]
        [Column("Last Name")]
        public string LastName { get; set; }
        

    }
}
