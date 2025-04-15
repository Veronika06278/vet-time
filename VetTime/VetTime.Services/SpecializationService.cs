using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data;
using VetTime.Services.Interfaces;

namespace VetTime.Services
{
    public class SpecializationService : ISpecializationService
    {
        private readonly ApplicationDbContext _dbContext;
        public SpecializationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<string> GetAllSpecializations()
        {
            return _dbContext.Specializations
                           .Select(s => s.Name)
                           .OrderBy(name => name)
                           .ToList();

        }
    }
}
