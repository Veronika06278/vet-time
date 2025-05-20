using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VetTime.Data.Models;

namespace VetTime.Web.Areas.Admin.Models
{
    public class AdminDashboardViewModel
    {
        public Guid ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientEmail { get; set; }

        public Guid VetId { get; set; }
        public string VetFirstName { get; set; }
        public string VetLastName { get; set; }
        public string VetEmail { get; set; }

        public Guid AppointmentId { get; set; }
        public DateTime AppintmentTime { get; set; }
        public List<AppointmentRecordViewModel> Appointments { get; set; }


        public int TotalUsers { get; set; }
        public int TotalClients { get; set; }
        public int ActiveVeterinarians { get; set; }
        public int UpcomingWeekAppointments { get; set; }
        public Dictionary<DateTime, int> ReservationsByDay { get; set; }
        public Dictionary<string, int> ReservationsByCity { get; set; }
    }
}
