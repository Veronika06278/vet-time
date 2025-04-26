using Microsoft.EntityFrameworkCore;
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

        public List<VetViewModel> GetVetsInformation(string? specialization, string? cityName, string? firstName, string? lastName)
        {
            

            IQueryable<Veterinarian> vetQuery = _dbContext.Veterinarians
                .Include(v=>v.Address)
                .ThenInclude(a=>a.City)   //Eager Loading
                .Include(v=>v.VetSpecializations)
                .ThenInclude(vs=>vs.Specialization)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrEmpty(specialization))
            {
               vetQuery = vetQuery.Where(v => v.VetSpecializations.Any(vs => vs.Specialization.Name == specialization));
                
            }
            
            if (!string.IsNullOrEmpty(cityName))
            {
               vetQuery = vetQuery.Where(v=>v.Address.City.Name == cityName);
                
            }
            
            if (!string.IsNullOrEmpty(firstName))
            {
                string wildCard = $"%{firstName}%";
               vetQuery = vetQuery.Where(v => EF.Functions.Like(v.FirstName, wildCard));
                
            }
            
            if (!string.IsNullOrEmpty(lastName))
            {
                string wildCard = $"%{lastName}%";
               vetQuery = vetQuery.Where(v => EF.Functions.Like(v.LastName, wildCard));
                
            }

            List <VetViewModel> vetResults = vetQuery.Select(v=> new VetViewModel
            {
                Id = v.Id,
                FirstName= v.FirstName,
                LastName= v.LastName,
                ImageUrl = v.ImageUrl,
                Address = $"{v.Address.City.Name}, {v.Address.District}, {v.Address.Street} {v.Address.Number}",
                Rate = v.Ratings.Any() ? v.Ratings.Average(r => r.Rate) : 0,
                Specializations=v.VetSpecializations.Select(vs=> new SpecializationViewModel
                {
                    Id= vs.Specialization.Id,
                    Name=vs.Specialization.Name,
                }).ToList()
            }).OrderByDescending(v => v.Rate).ToList();

            return vetResults;

        }

        public VetDetailsViewModel GetVetDetails(Guid id)
        {
            var vetQuery = _dbContext.Veterinarians
                .Where(v => v.Id == id)
                .Include(v => v.Address)
                .ThenInclude(a => a.City)
                .Include(v => v.VetSpecializations)
                .ThenInclude(vs => vs.Specialization)
                .Include(v => v.Ratings)
                .AsNoTracking()
                .FirstOrDefault();

            if (vetQuery == null)
            {
                return null!;
            }

            var slots = _dbContext.Appointments
                .Where(a => a.VetId == id && !a.HasVisited && !a.IsDeleted && a.AppointmentTime > DateTime.Now)
                .OrderBy(a => a.AppointmentTime)
                .Select(a => new AppointmentSlotViewModel
                {
                    Id = a.Id,
                    AppointmentTime = a.AppointmentTime,
                    HasVisited = a.HasVisited,
                    AppointmentType = a.AppointmentType.ToString()
                })
                .ToList();

            return new VetDetailsViewModel
            {
                Id = vetQuery.Id,
                FirstName = vetQuery.FirstName,
                LastName = vetQuery.LastName,
                ImageUrl = vetQuery.ImageUrl,
                Address = $"{vetQuery.Address.City.Name}, {vetQuery.Address.District}, {vetQuery.Address.Street} {vetQuery.Address.Number}",
                Rate = vetQuery.Ratings.Any() ? vetQuery.Ratings.Average(r => r.Rate) : 0,
                Specializations = vetQuery.VetSpecializations .Select(vs => vs.Specialization.Name) .ToList(),
                AvailableSlots = slots
            };
        }

    }
}
