using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Home
{
    public class HomeViewModel : IValidatableObject
    {
        //public string CityName { get; set; }

        //public List<string> Cities { get; set; } = new List<string>();

        //public string Specialization { get; set; }
        //public List<string> Specializations { get; set; } = new List<string>();

        //public List<VetViewModel> Vets { get; set; } = new List<VetViewModel>();

        public string CityName { get; set; }

        public List<string> Cities { get; set; } = new List<string>();

        public string Specialization { get; set; }

        public List<string> Specializations { get; set; } = new List<string>();

        public string VetFullName { get; set; } // Две имена на ветеринар

        public List<VetViewModel> Vets { get; set; } = new List<VetViewModel>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(CityName)
                && string.IsNullOrWhiteSpace(Specialization)
                && string.IsNullOrWhiteSpace(VetFullName))
            {
                yield return new ValidationResult(
                    "Please fill in at least one of the fields: city, specialization, or veterinarian name.",
                    new[] { nameof(CityName), nameof(Specialization), nameof(VetFullName) }
                );
            }
        }
    }
}
