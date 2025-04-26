using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class VetSpecialization
    {
        [Required]
        [ForeignKey(nameof(Veterinarian))]
        public Guid VetId { get; set; }
        public Veterinarian Veterinarian { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Specialization))]
        public int Id { get; set; }
        public Specialization Specialization { get; set; } = null!;
    }
}
