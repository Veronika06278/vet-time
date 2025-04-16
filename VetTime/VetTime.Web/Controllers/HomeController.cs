

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VetTime.Web.ViewModels.Errors;
using VetTime.Web.ViewModels.Home;
using VetTime.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace VetTime.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ISpecializationService _specializationService;
        private readonly IVetService _vetService;

        public HomeController(
            ICityService cityService,
            ISpecializationService specializationService,
            IVetService vetService)
        {
            _cityService = cityService;
            _specializationService = specializationService;
            _vetService = vetService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Cities = _cityService.GetAllCityNames(),
                Specializations = _specializationService.GetAllSpecializations()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Specializations = _specializationService.GetAllSpecializations();
                model.Cities = _cityService.GetAllCityNames();
                return View(model);
            }
            model.Vets = _vetService.GetVetsInformation(model.Specialization, model.CityName, model.VetFullName);
            model.Cities = _cityService.GetAllCityNames();
            model.Specializations = _specializationService.GetAllSpecializations();
            return View(model);
        }

        [HttpGet]
        public IActionResult Recommendations([FromQuery] HomeViewModel model)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, validationResults, true);

            if (!isValid)
            {
                ModelState.Clear(); 
                foreach (var error in validationResults)
                {
                    ModelState.AddModelError(string.Empty, error.ErrorMessage);
                }

                model.Cities = _cityService.GetAllCityNames();
                model.Specializations = _specializationService.GetAllSpecializations();
                return View(model);
            }

            model.Cities = _cityService.GetAllCityNames();
            model.Specializations = _specializationService.GetAllSpecializations();
            model.Vets = _vetService.GetVetsInformation(model.Specialization, model.CityName, model.VetFullName);

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



















//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;
//using VetTime.Web.ViewModels.Errors;
//using VetTime.Web.ViewModels.Home;
//using VetTime.Services;
//using Microsoft.Extensions.Logging;
//using VetTime.Services.Interfaces;

//namespace VetTime.Web.Controllers
//{
//    public class HomeController : Controller
//    {

//        private readonly ICityService _cityService;
//        private readonly ISpecializationService _specializationService;
//        private readonly IVetService _vetService;

//        public HomeController(
//            ICityService cityService,
//            ISpecializationService specializationService,
//            IVetService vetService
//            )
//        {

//            _cityService = cityService;
//            _specializationService = specializationService;
//            _vetService = vetService;
//        }

//        [HttpGet]
//        public IActionResult Index()
//        {
//            var viewModel = new HomeViewModel
//            {
//                Cities = _cityService.GetAllCityNames(),
//                Specializations = _specializationService.GetAllSpecializations(),
//            };

//            return View(viewModel);
//        }

//        [HttpPost]
//        public IActionResult Index(HomeViewModel model)
//        {
//            if (!ModelState.IsValid)
//            {
//                model.Specializations = _specializationService.GetAllSpecializations();
//                model.Cities = _cityService.GetAllCityNames();
//                return View(model);
//            }
//            model.Vets = _vetService.GetVetsInformation(model.Specialization, model.CityName, model.VetFullName);
//            model.Cities = _cityService.GetAllCityNames();
//            model.Specializations = _specializationService.GetAllSpecializations();
//            return View(model);





//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        public IActionResult Info()
//        {
//            int year = DateTime.Now.Year;
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}

