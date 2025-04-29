using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Services.Interfaces
{
    public interface ICityService
    {
        public Guid Add(string cityName);
        public Task<List<string>> GetAllCityNames();
    }
}
