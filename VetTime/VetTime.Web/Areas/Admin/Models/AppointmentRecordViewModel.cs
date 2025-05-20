namespace VetTime.Web.Areas.Admin.Models
{
    public class AppointmentRecordViewModel
    {
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string VetFirstName { get; set; }
        public string VetLastName { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}
