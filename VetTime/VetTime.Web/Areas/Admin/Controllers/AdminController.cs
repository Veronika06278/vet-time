using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var appointments = _db.Appointments
                .Include(a => a.Client)
                .Include(a => a.Veterinarian)
                .Select(a => new AppointmentRecordViewModel
                {
                    ClientFirstName = a.Client.FirstName,
                    ClientLastName = a.Client.LastName,
                    VetFirstName = a.Veterinarian.FirstName,
                    VetLastName = a.Veterinarian.LastName,
                    AppointmentTime = a.AppointmentTime
                }).ToList();

            var allUsers= _db.Users.Select(u=>u.Id).Count();
            var userRoles= _db.UserRoles.Select(ur=>ur.UserId).Distinct().Count();
            var model = new AdminDashboardViewModel
            {
                TotalUsers = allUsers,
                TotalClients = allUsers-userRoles,
                ActiveVeterinarians = _db.Veterinarians.Where(v=>v.IsDeleted==false).Count(),
                UpcomingWeekAppointments = _db.Appointments.Count(a => a.AppointmentTime >= DateTime.Now && a.AppointmentTime <= DateTime.Now.AddDays(7)),
                ReservationsByDay = _db.Appointments
                 .Where(a => a.AppointmentTime >= DateTime.Now)
                 .GroupBy(a => a.AppointmentTime.Date)
                 .ToDictionary(g => g.Key, g => g.Count()),
                Appointments = appointments
            };
            
            return View(model);
        }

    }
}
