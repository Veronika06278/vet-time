using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Vet
{
    public class CreateAppointmentViewModel
    {
        public DateTime AppointmentTime { get; set; }
        public Guid VetId { get; set; }
        public List<AppointmentSlotViewModel> AvailableSlots { get; set; } = new List<AppointmentSlotViewModel>();
        [Required]
        public Guid SelectedSlotId { get; set; }
    }
}
