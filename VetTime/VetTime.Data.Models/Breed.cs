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
        }
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string BreedName { get; set; } = null!;

        public ICollection<Animal> Animals { get; set; }
    }
}
