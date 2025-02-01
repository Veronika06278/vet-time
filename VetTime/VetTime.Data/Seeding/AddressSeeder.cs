using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class AddressSeeder
    {
        public static ICollection<Address> GenerateAddresses()
        {
            List<Address> values = new List<Address>();
            values.Add(new Address()
            {
                Id = new Guid("4de1b74b-9a84-4b00-a70f-178b7956ef32"),
                District = "Lozenets",
                Street = "Kozyak",
                Number = 16,
                CityId = new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"),
            });
            return values;
        }
    }
}
