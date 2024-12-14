using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VetTime.Data.Models
{
    public class Veterinarian
    {
        public Veterinarian()
        {
            Id= Guid.NewGuid();
            Ratings = new HashSet<Rating>();
            Appointments = new HashSet<Appointment>();
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [ForeignKey(nameof(Address))]
        [Required]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }= null!;

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Appointment> Appointments { get; set; }


        
    }
}
