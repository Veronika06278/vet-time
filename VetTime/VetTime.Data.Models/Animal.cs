using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models.Enums;

namespace VetTime.Data.Models
{
    public class Animal
    {
        public Animal()
        {
            Id=Guid.NewGuid();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public Guid Id { get; init; }
        [Required]
        public string Name { get; set; } = null!;
        public string? PhotoURL { get; set; }
        public AnimalCategory AnimalCategory { get; set; }

        [Required]
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Breed))]
        public Guid BreedId { get; set; }
        public Breed Breed { get; set; } = null!;

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
