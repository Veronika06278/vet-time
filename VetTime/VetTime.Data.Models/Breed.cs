using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models.Enums;

namespace VetTime.Data.Models
{
    public class Breed
    {
        public Breed()
        {
            Id=Guid.NewGuid();
            Animals = new HashSet<Animal>();
            CreatedOn = DateTime.Now;
            IsDeleted=false;
        }
        [Key]
        [Required]
        public Guid Id { get; init; }
        [Required]
        public string BreedName { get; set; } = null!;

        public ICollection<Animal> Animals { get; set; }

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
