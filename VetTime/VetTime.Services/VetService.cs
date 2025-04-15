using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data;
using VetTime.Data.Models;
using VetTime.Services.Interfaces;
using VetTime.Web.ViewModels.Home;

namespace VetTime.Services
{
    public class VetService : IVetService
    {
        private readonly ApplicationDbContext _dbContext;

        public VetService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Guid Add(Guid addressId, Guid userId, string firstName, string lastName, string email)
        {
            Veterinarian veterinarian = new Veterinarian()
            {
                FirstName = firstName,
                LastName = lastName,
                AddressId = addressId,
                UserId = userId,
            };
            _dbContext.Add(veterinarian);
            _dbContext.SaveChanges();
            return veterinarian.Id;
        }

        public List<VetViewModel> GetVetsInformation(string specialization, string cityName)
        {
            return _dbContext.Veterinarians.Where(v=>
                v.VetSpecializations.Any(vs=>vs.Specialization.Name == specialization)&&
                v.Address.City.Name==cityName)
                .Select(v=>new VetViewModel()
                {
                    FullName=$"{v.FirstName} {v.LastName}",
                    //ImageUrl=v.
                    Address=$"{v.Address.City.Name}, {v.Address.District}, {v.Address.Street} {v.Address.Number}",
                    Rate=v.Ratings.Average(v=>v.Rate),
                }).ToList();
        }
    }
}
