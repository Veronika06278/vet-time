using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class VetSpecializationSeeder
    {
        public static ICollection<VetSpecialization> GenerateVetSpecialization()
        {
            List<VetSpecialization> values = new List<VetSpecialization>();
            values.Add(new VetSpecialization()
            {
                VetId= new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                Id=2

            });
            return values;
        }
    }
}
