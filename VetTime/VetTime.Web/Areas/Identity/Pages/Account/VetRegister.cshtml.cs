
#nullable disable

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using VetTime.Data;
using VetTime.Data.Models;
using VetTime.Services.Interfaces;
using VetTime.Web.Common;
using VetTime.Web.ViewModels.Home;

namespace VetTime.Web.Areas.Identity.Pages.Account
{
    public class VetRegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly ApplicationDbContext _dbcontext;
        private readonly ICityService _cityService;
        private readonly IAddressService _addressService;
        private readonly IVetService _vetService;
        private readonly ISpecializationService _specializationService;

        public VetRegisterModel(
            UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext dbContext,
            ICityService cityService,
            IAddressService addressService,
            IVetService vetService,
            ISpecializationService specializationService
            )
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _dbcontext = dbContext;
            _cityService = cityService;
            _addressService = addressService;
            _vetService = vetService;
            _specializationService = specializationService;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public List<string> Cities { get; set; } = new List<string>();
        
        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        /// 
        public class InputModel
        {

            [Required]
            [StringLength(50, MinimumLength = 2)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [MaxLength(50)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            public string PhoneNumber { get; set; }

            [Required]
            [MaxLength(100)]
            public string District { get; set; }

            [Required]
            [MaxLength(100)]
            public string Street { get; set; }

            [Required]
            public int Number { get; set; }

            [Required]
            public string CityName { get; set; }


            public bool IsCheckedDomesticAnimals { get; set; }
            public bool IsCheckedExoticAnimals { get; set; }
            public bool IsCheckedFarmAnimals { get; set; }


            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }


        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            this.Cities = await GetCityNames();
            
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (Input.IsCheckedExoticAnimals == false &&
               Input.IsCheckedDomesticAnimals == false &&
               Input.IsCheckedFarmAnimals == false)
            {
                ModelState.AddModelError("Input.IsCheckedExoticAnimals", "At least one specialization must be checked");
                ModelState.AddModelError("Input.IsCheckedDomesticAnimals", "At least one specialization must be checked");
                ModelState.AddModelError("Input.IsCheckedFarmAnimals", "At least one specialization must be checked");
            }

            if (ModelState.IsValid)
            {
                var user = CreateUser();

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                IdentityResult setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                //Tuk suzdavam ApplicationUser Entity
                var result = await _userManager.CreateAsync(user, Input.Password);
                

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, ApplicationConstants.VeterinarianRoleName);

                    //Tuk suzdava City Entity
                    Guid cityId = _cityService.Add(Input.CityName);
                    //Tuk suzdavam adress Entity
                    Guid addressId = _addressService.Add(cityId, Input.District, Input.Street, Input.Number);
                    //Tuk suzdavam Veterinarian Entity
                    Guid vetId = _vetService.Add(addressId, user.Id,Input.FirstName, Input.LastName, Input.Email);

                    
                    
                    if (Input.IsCheckedDomesticAnimals == true)
                    {
                        this.AddVetSpecialization("Domestic Animals", vetId);
                    }

                    if (Input.IsCheckedExoticAnimals == true)
                    {
                        this.AddVetSpecialization("Exotic Animals", vetId);
                    }

                    if (Input.IsCheckedFarmAnimals == true)
                    {
                        this.AddVetSpecialization("Farm Animals", vetId);
                    }

                    //Tuk trqbwa da si dobawq usera da e rolq vet
                    await _userManager.AddToRoleAsync(user, ApplicationConstants.VeterinarianRoleName);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    //TODO:return vetr to profile page
                    return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            OnGetAsync();
            return Page();
            
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }

        private async Task<List<string>> GetCityNames()
        {
            List<string> cityNames = await _dbcontext.Cities
                .OrderBy(city => city.Name)
                .Select(city => city.Name)
                .ToListAsync();
            return cityNames;

        }
        private void AddVetSpecialization(string specializationName, Guid vetId)
        {
            List<SpecializationViewModel> specializations = _specializationService.GetAllSpecializations();
            
            SpecializationViewModel spec = specializations.Where(s => s.Name == specializationName).FirstOrDefault();
            if (spec != null)
            {
                _specializationService.AddVetSpecialization(vetId, spec.Id);
            }
        }
    }
}
