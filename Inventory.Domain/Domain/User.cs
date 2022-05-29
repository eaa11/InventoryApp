using Inventory.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models.Domain
{
    public class User:BasicInformation
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        public bool Role { get; set; }
    }
}
