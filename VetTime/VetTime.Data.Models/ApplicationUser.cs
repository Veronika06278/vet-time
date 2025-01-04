using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        //TODO: Add relation to client or veterinarian
        [ForeignKey(nameof(Client))]
        public Guid? ClientId { get; set; }
        public Client? Client { get; set; }

        [ForeignKey(nameof(Veterinarian))]
        public Guid? VeterinarianId { get; set; }
        public Veterinarian? Veterinarian { get; set; }
    }
}
