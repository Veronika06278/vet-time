using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class CitySeeder
    {
        public static ICollection<City> GenerateCities()
        {
            List<City> values = new List<City>();
            values.Add(new City()
            {
                Id=new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
                Name="Sofia",
            });
            return values;
        }
    }
}
