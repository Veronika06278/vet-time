using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTime.Data;
using VetTime.Services.Interfaces;
using VetTime.Web.ViewModels.Home;

namespace VetTime.Web.Controllers
{
    public class VetController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ISpecializationService _specializationService;
        private readonly IVetService _vetService;
        private readonly ApplicationDbContext _dbContext;

        public VetController(
            ICityService cityService,
            ISpecializationService specializationService,
            IVetService vetService,
            ApplicationDbContext dbContext)
        {
            _cityService = cityService;
            _specializationService = specializationService;
            _vetService = vetService;
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Recommendations(HomeViewModel model)
        {
            //if (!ModelState.IsValid)
            //{

            //    model.Cities = _cityService.GetAllCityNames();
            //    model.Specializations = _specializationService.GetAllSpecializations();
            //    return View(model);
            //}

            model.Cities = _cityService.GetAllCityNames();
            model.Specializations = _specializationService.GetAllSpecializations();
            model.Vets = _vetService
                .GetVetsInformation(/*model.Id, */model.Specialization, model.CityName, model.VetFirstName, model.VetLastName);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var model = _vetService.GetVetDetails(id);
            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult BookAppointment(Guid appointmentId)
        {
            var appointment = _dbContext.Appointments
                .FirstOrDefault(a => a.Id == appointmentId);
            if (appointment == null)
                return NotFound();

            appointment.HasVisited = true;
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Details), new { id = appointment.VetId });
        }


        [HttpGet]
        public IActionResult SelectSlot(Guid id)
        {
            // id is the veterinarian's Id
            var vetDetails = _vetService.GetVetDetails(id);
            if (vetDetails == null) return NotFound();

            var model = new CreateAppointmentViewModel
            {
                VetId = id,
                AvailableSlots = vetDetails.AvailableSlots
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmSlot(CreateAppointmentViewModel model)
        {
            // model.SelectedSlotId holds the appointment slot to book
            // Mark booked in database
            var slot = _dbContext.Appointments.Find(model.SelectedSlotId);
            if (slot == null) return NotFound();

            slot.HasVisited = true;
            _dbContext.SaveChanges();

            // Redirect back to details of the vet
            return RedirectToAction("Details", new { id = model.VetId });
        }
    }
}
