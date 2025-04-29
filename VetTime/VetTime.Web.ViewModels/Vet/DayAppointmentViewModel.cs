using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Vet
{
    public class DayAppointmentViewModel
    {
        public DateTime Day { get; set; }
        public string ShortName => Day.ToString("dd");
        public string Weekday => Day.ToString("ddd");
        public List<HourAppointmentViewModel> Slots { get; set; }
            = new List<HourAppointmentViewModel>();
    }
}
