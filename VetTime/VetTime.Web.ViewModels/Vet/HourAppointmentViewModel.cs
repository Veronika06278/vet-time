using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Vet
{
    public class HourAppointmentViewModel
    {
        public DateTime Time { get; set; }       
        public bool IsBooked { get; set; }       
        public bool IsSelected { get; set; }
    }
}
