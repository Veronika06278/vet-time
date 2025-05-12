using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetTime.Data;
using VetTime.Web.Areas.Admin.Models;
using static VetTime.Web.Common.ApplicationConstants;

namespace VetTime.Web.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db) => 
            _db = db;

        public IActionResult Dashboard()
        {
            var vm = new AdminDashboardViewModel
            {
                TotalUsers = _db.Users.Count(),
                TotalClients = _db.Clients.Count(),

                UpcomingWeekAppointments = _db.Appointments
                .Count(a => a.AppointmentTime >= DateTime.Today && a.AppointmentTime < DateTime.Today.AddDays(7)),

                ReservationsByDay = _db.Appointments
                .Where(a => a.AppointmentTime >= DateTime.Today && a.AppointmentTime < DateTime.Today.AddDays(7))
                .GroupBy(a => a.AppointmentTime.Date)
                .ToDictionary(g => g.Key, g => g.Count()),
            };
            return View(vm);
        }
    }
}
