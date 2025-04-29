using Microsoft.EntityFrameworkCore;
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
    public class CityService : ICityService
    {
        private readonly ApplicationDbContext _dbContext;
        public CityService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Add(string cityName)
        {
           List<string>cityNames= _dbContext.Cities.Select(c => c.Name).ToList();

            City city;
            if (cityNames.Contains(cityName))
            {
                city= _dbContext.Cities.Where(s => s.Name == cityName).First();
                return city.Id;
            }

            city = new City
            {
                Name = cityName
            };
            _dbContext.Add(city);
            _dbContext.SaveChanges();
            return city.Id;
        }

        public async Task<List<string>> GetAllCityNames()
        {
            return await _dbContext.Cities
                           .Select(c => c.Name)
                           .OrderBy(name => name)
                           .ToListAsync();
            
        }
        

    }
}
