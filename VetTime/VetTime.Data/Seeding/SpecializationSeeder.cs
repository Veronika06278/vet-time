using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class SpecializationSeeder
    {
        public static ICollection<Specialization> GenerateSpecializations()
        {
            List<Specialization> values = new List<Specialization>();
            values.Add(new Specialization()
            {
                Id = 1,
                Name="Exotic Animals"
            });
            values.Add(new Specialization()
            {
                Id = 2,
                Name = "Domestic Animals"
            });
            values.Add(new Specialization()
            {
                Id = 3,
                Name = "Farm Animals"
            });
            return values;
        }
    }
}
