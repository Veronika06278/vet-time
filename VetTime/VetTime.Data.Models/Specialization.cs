using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class Specialization
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<VetSpecialization> VetSpecializations { get; set; } = new HashSet<VetSpecialization>();
        public ICollection<Animal>Animals { get; set; }=new HashSet<Animal>();

    }
}
