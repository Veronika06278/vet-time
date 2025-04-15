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
            List<City> values = new List<City>()
        {
            new City() { Id = new Guid("e1e9bc98-8d9a-42a9-b07b-9523ff504ab1"), Name = "Sofia" },
            new City() { Id = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), Name = "Plovdiv" },
            new City() { Id = new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"), Name = "Varna" },
            new City() { Id = new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"), Name = "Burgas" },
            new City() { Id = new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"), Name = "Ruse" },
            new City() { Id = new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"), Name = "Stara Zagora" },
            new City() { Id = new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"), Name = "Pleven" },
            new City() { Id = new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"), Name = "Sliven" },
            new City() { Id = new Guid("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"), Name = "Dobrich" },
            new City() { Id = new Guid("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"), Name = "Shumen" },
            new City() { Id = new Guid("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"), Name = "Pernik" },
            new City() { Id = new Guid("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"), Name = "Haskovo" },
            new City() { Id = new Guid("2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c"), Name = "Yambol" },
            new City() { Id = new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"), Name = "Pazardzhik" },
            new City() { Id = new Guid("4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e"), Name = "Blagoevgrad" },
            new City() { Id = new Guid("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"), Name = "Veliko Tarnovo" },
            new City() { Id = new Guid("6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a"), Name = "Vratsa" },
            new City() { Id = new Guid("7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b"), Name = "Gabrovo" },
            new City() { Id = new Guid("8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c"), Name = "Vidin" },
            new City() { Id = new Guid("9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d"), Name = "Kardzhali" },
            new City() { Id = new Guid("0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e"), Name = "Kyustendil" },
            new City() { Id = new Guid("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"), Name = "Montana" },
            new City() { Id = new Guid("2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a"), Name = "Lovech" },
            new City() { Id = new Guid("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"), Name = "Razgrad" },
            new City() { Id = new Guid("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"), Name = "Targovishte" },
            new City() { Id = new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"), Name = "Silistra" },
            new City() { Id = new Guid("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"), Name = "Smolyan" }
        };

            return values;
        }
    }
}
