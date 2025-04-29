using System;
using System.Collections.Generic;

namespace VetTime.Web.ViewModels.Vet
{
    public class VetDetailsViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }
        public string Address { get; set; }
        public double Rate { get; set; }
        public List<string> Specializations { get; set; } = new List<string>();

        // List of already booked slots (from database)
        public List<AppointmentSlotViewModel> BookedSlots { get; set; } = new List<AppointmentSlotViewModel>();

        // Dictionary of all slots in the upcoming period: key = DateTime slot, value = booked slot or null if free
        public Dictionary<DateTime, AppointmentSlotViewModel> AllAppointments { get; set; } = new Dictionary<DateTime, AppointmentSlotViewModel>();
    }
}
