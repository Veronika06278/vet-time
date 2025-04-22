using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Home
{
    public class VetViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }
        public string Address { get; set; }
        public double Rate { get; set; }
        public List<string> Specializations { get; set; } = new List<string>();
    }
}
