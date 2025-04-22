using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Web.ViewModels.Home;

namespace VetTime.Services.Interfaces
{
    public interface IVetService
    {
        public Guid Add(Guid addressId, Guid userId, string firstName, string lastName, string email);
        public List<VetViewModel> GetVetsInformation(Guid id, string? specialization, string? cityName, string? firstName, string? lastName);
        public VetDetailsViewModel GetVetDetails(Guid id);
    }
}
