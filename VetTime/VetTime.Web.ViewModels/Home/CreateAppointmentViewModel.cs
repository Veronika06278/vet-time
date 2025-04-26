using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Home
{
    public class CreateAppointmentViewModel
    {
        public Guid VetId { get; set; }
        public List<AppointmentSlotViewModel> AvailableSlots { get; set; } = new();
        public Guid SelectedSlotId { get; set; }
    }
}
