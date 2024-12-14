using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class Client
    {
        public Client()
        {
            Id = Guid.NewGuid();
            Appointments=new HashSet<Appointment>();
            Animals=new HashSet<Animal>();
            Ratings = new HashSet<Rating>();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public Guid Id { get; init; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = null!;

        public int NotVisitedCounter { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Animal> Animals { get; set; }
        public ICollection<Rating> Ratings { get; set; }

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
