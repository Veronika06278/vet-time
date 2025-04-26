using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Home
{
    public class AppointmentSlotViewModel
    {
        public Guid Id { get; set; }
        public DateTime AppointmentTime { get; set; }
        public bool HasVisited { get; set; }
        public string AppointmentType { get; set; } = string.Empty;

    }
}
