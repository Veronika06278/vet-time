using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Vet
{
    public class VetScheduleViewModel
    {
        public Guid VetId { get; set; }
        public List<DayAppointmentViewModel> Days { get; set; } = new List<DayAppointmentViewModel>();

        [Required(ErrorMessage = "Please select a time slot.")]
        public DateTime? SelectedSlotTime { get; set; }
    }
}
