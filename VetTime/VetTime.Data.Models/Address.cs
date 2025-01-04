using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid();
            Veterinarians = new HashSet<Veterinarian>();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(100)]
        public string District { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Street { get; set; } = null!;

        [Required]
        public int Number { get; set; }

        [ForeignKey(nameof(City))]
        [Required]
        public Guid CityId { get; set; }
        
        public City City { get; set; }=null!;

        public ICollection<Veterinarian> Veterinarians { get; set; }

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }

    }
}
