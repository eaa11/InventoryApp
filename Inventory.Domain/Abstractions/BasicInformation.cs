using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Domain.Abstractions
{
    [Table("BasicInfo")]
    public abstract class BasicInformation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "ntext")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(12)]
        [Column("Phone Number")]
        public string Telephone { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

    }
}
