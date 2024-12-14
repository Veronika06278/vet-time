using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class Rating
    {
        [Required]
        [ForeignKey(nameof(Veterinarian))]
        public Guid VetId { get; set; }
        public Veterinarian Veterinarian { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }=null!;

        [Range(1,5)]
        [Required]
        public int Rate { get; set; }

        public DateTime DateTime { get; set; }

        public string? Comment { get; set; } 
    }
}
