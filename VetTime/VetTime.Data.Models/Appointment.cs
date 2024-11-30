using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class Appointment
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Id))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime AppointmentTime { get; set; }

        public bool HasVisited { get; set; }
    }
}
