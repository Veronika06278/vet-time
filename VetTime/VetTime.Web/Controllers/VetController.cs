using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTime.Data;
using VetTime.Data.Models.Enums;
using VetTime.Data.Models;
using VetTime.Services.Interfaces;
using VetTime.Web.ViewModels.Home;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using VetTime.Web.ViewModels.Vet;
using VetTime.Web.Extentions;

namespace VetTime.Web.Controllers
{
    public class VetController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ISpecializationService _specializationService;
        private readonly IVetService _vetService;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public VetController(
            ICityService cityService,
            ISpecializationService specializationService,
            IVetService vetService,
            ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _cityService = cityService;
            _specializationService = specializationService;
            _vetService = vetService;
            _dbContext = dbContext;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Recommendations()
        {
            HomeViewModel model = new HomeViewModel();
            model.Cities = await _cityService.GetAllCityNames();
            model.Specializations = _specializationService.GetAllSpecializations();
            model.Vets = _vetService
                .GetVetsInformation(model.Specialization, model.CityName, model.VetFirstName, model.VetLastName);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Recommendations(HomeViewModel model)
        {
            model.Cities = await _cityService.GetAllCityNames();
            model.Specializations = _specializationService.GetAllSpecializations();
            model.Vets = _vetService
                .GetVetsInformation(model.Specialization, model.CityName, model.VetFirstName, model.VetLastName);

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            VetDetailsViewModel model = await _vetService.GetVetDetails(id);
            model.AllAppointments = StructureVetAppointments(model.BookedSlots);


            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookAppointment(Guid vetId, DateTime appointmentTime)
        {
            if (appointmentTime == default)
                return RedirectToAction(nameof(Details), new { id = vetId });

            appointmentTime = appointmentTime.AddHours(3);

            var userIdString = User.GetId();
            if (string.IsNullOrEmpty(userIdString)
             || !Guid.TryParse(userIdString, out var userIdGuid))
            {
                return RedirectToAction(nameof(Recommendations));
            }

            var client = await _dbContext.Clients
                .SingleOrDefaultAsync(c => c.UserId == userIdGuid);
            
            bool clash = await _dbContext.Appointments.AnyAsync(a =>
                a.VetId == vetId &&
                a.AppointmentTime == appointmentTime &&
                !a.IsDeleted);
            if (clash)
            {
                TempData["Error"] = "Този час вече е запазен.";
                return RedirectToAction(nameof(Details), new { id = vetId });
            }

            var appt = new Appointment
            {
                VetId = vetId,
                ClientId = client!.Id,
                AppointmentTime = appointmentTime,
                AppointmentType = AppointmentType.Checkup,
                HasVisited = false,
                CreatedOn = DateTime.UtcNow,
                IsDeleted = false
            };
            _dbContext.Appointments.Add(appt);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }



        private Dictionary<DateTime, AppointmentSlotViewModel> StructureVetAppointments(List<AppointmentSlotViewModel> bookedSlots)
        {
            DateTime today = DateTime.Now.Date;
            DateTime startDateAndHour=today.AddDays(1).AddHours(9);
            DateTime endDateAndHour = today.AddDays(6).AddHours(17);

            Dictionary<DateTime, AppointmentSlotViewModel> allSlots = new Dictionary<DateTime, AppointmentSlotViewModel>();

            DateTime currentTimeSlot = startDateAndHour;
            while (currentTimeSlot <= endDateAndHour)
            {
                if (bookedSlots.Any(x=>x.AppointmentTime== currentTimeSlot))
                {
                    AppointmentSlotViewModel appointedTime = bookedSlots.Where(x => x.AppointmentTime == currentTimeSlot).First();
                    allSlots.Add(currentTimeSlot, appointedTime);
                }
                else
                {
                    allSlots.Add(currentTimeSlot, null); //this time and day are not booked  null -> free
                    
                }
                currentTimeSlot=currentTimeSlot.AddHours(1);
                if (currentTimeSlot.Hour>17)
                {
                    currentTimeSlot = currentTimeSlot.Date.AddDays(1).AddHours(9);
                    
                }

                
            }
            return allSlots;

        }
    }
}
