using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class City
    {
        public City()
        {
            Id= Guid.NewGuid();
            Addresses=new HashSet<Address>();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public Guid Id { get; init; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; }

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
