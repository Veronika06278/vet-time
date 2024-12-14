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
    public class Appointment
    {
        public Appointment()
        {
            Id= Guid.NewGuid();
            CreatedOn = DateTime.Now;
            IsDeleted=false;
        }

        [Required]
        [Key]
        public Guid Id { get; init; }

        [Required]
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Veterinarian))]
        public Guid VetId { get; set; }
        public Veterinarian Veterinarian { get; set; } = null!;

        public AppointmentType AppointmentType { get; set; }

        public DateTime AppointmentTime { get; set; }

        public bool HasVisited { get; set; }

        [Required]
        [ForeignKey(nameof(Animal))]
        public Guid AnimalId { get; set; }
        public Animal Animal { get; set; } = null!;

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
