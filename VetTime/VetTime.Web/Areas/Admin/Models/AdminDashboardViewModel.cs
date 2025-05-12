namespace VetTime.Web.Areas.Admin.Models
{
    public class AdminDashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalClients { get; set; }
        public int ActiveVeterinarians { get; set; }
        public int UpcomingWeekAppointments { get; set; }
        public Dictionary<DateTime, int> ReservationsByDay { get; set; }
        public Dictionary<string, int> ReservationsByCity { get; set; }
    }
}
