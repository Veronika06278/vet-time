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
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

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
    }
}
