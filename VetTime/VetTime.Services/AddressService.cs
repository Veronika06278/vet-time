using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data;
using VetTime.Data.Models;
using VetTime.Services.Interfaces;

namespace VetTime.Services
{
    public class AddressService : IAddressService
    {
        private readonly ApplicationDbContext _dbContext;
        public AddressService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Add(Guid cityId, string district, string street, int number)
        {
          Address? address = _dbContext.Addresses
                .Where(a=>a.CityId==cityId && a.District==district && a.Street==street && a.Number==number)
                .FirstOrDefault();
            if (address is not null)
            {
                return address.Id;
            }

            address = new Address()
            {
                CityId = cityId,
                District = district,
                Street = street,
                Number = number,
            };
            _dbContext.Add(address);
            _dbContext.SaveChanges();
            return address.Id;
        }

    }
}
