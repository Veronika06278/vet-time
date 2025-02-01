using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class VeterinarianSeeder
    {
        public static ICollection<Veterinarian> GenerateVeterinarians()
        {
            List<Veterinarian> values = new List<Veterinarian>();
            values.Add(new Veterinarian()
            {
                Id = new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                FirstName = "Veronika",
                LastName = "Zheleva",
                AddressId = new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                UserId = new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),

            }); 
            return values;
        }
    }
}
