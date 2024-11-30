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
        [Required]
        [Key]
        public int Id { get; set; }

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
        public int CityId { get; set; }
        
        public City City { get; set; }=null!;



    }
}
