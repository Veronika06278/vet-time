using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Web.ViewModels.Home;

namespace VetTime.Services.Interfaces
{
    public interface ISpecializationService
    {
        public List<SpecializationViewModel> GetAllSpecializations();
        public void AddVetSpecialization(Guid VetId, int specId);
    }
}
