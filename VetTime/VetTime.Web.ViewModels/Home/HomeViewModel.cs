using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Home
{
    public class HomeViewModel
    {
        public Guid Id { get; set; }
        public string? CityName { get; set; }

        public List<string> Cities { get; set; } = new List<string>();

        public string? Specialization { get; set; }

        public List<SpecializationViewModel> Specializations { get; set; } = new List<SpecializationViewModel>();

        public string? VetFirstName { get; set; } 
        public string? VetLastName { get; set; } 

        public List<VetViewModel> Vets { get; set; } = new List<VetViewModel>();

        
    }
}
