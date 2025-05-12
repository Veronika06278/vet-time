

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VetTime.Web.ViewModels.Errors;
using VetTime.Web.ViewModels.Home;
using VetTime.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using VetTime.Data;
using Microsoft.AspNetCore.Authorization;
using static VetTime.Web.Common.ApplicationConstants;

namespace VetTime.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ISpecializationService _specializationService;
        private readonly IVetService _vetService;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(
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

        [HttpGet]
        //[Authorize(Roles = VeterinarianRoleName)]
        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                Cities = await _cityService.GetAllCityNames(),
                Specializations = _specializationService.GetAllSpecializations()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(HomeViewModel model)
        {
           // this.User.Is

            if (!ModelState.IsValid)
            {
                model.Specializations = _specializationService.GetAllSpecializations();
                model.Cities = await _cityService.GetAllCityNames();
                return View(model);
            }
            model.Vets = _vetService.GetVetsInformation(/*model.Id, */model.Specialization, model.CityName, model.VetFirstName, model.VetLastName);
            model.Cities = await _cityService.GetAllCityNames();
            model.Specializations = _specializationService.GetAllSpecializations();
            return View(model);
        }

        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



