using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data;
using VetTime.Data.Models;
using VetTime.Services.Interfaces;
using VetTime.Web.ViewModels.Home;

namespace VetTime.Services
{
    public class SpecializationService : ISpecializationService
    {
        private readonly ApplicationDbContext _dbContext;
        public SpecializationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddVetSpecialization(Guid VetId, int specId)
        {
            VetSpecialization vs=new VetSpecialization()
            {
                VetId = VetId,
                Id = specId
            };
            _dbContext.VetSpecializations.Add(vs);
            _dbContext.SaveChanges();
        }

        public List<SpecializationViewModel> GetAllSpecializations()
        {
            return _dbContext.Specializations
                .AsNoTracking()
                .Select(s => new SpecializationViewModel
                {
                    Id= s.Id,
                    Name= s.Name,
                })
                .ToList();

        }

    }
}
