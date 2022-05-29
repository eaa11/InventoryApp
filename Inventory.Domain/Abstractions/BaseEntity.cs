using Inventory.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models.Abstractions
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        public State State { get; set; }

        [Required]
        public DateOnly RegisterDate { get; set; }

        public BaseEntity() => State = State.Unchanged;
    }
}
