using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Web.ViewModels.Home
{
    public class VetViewModel
    {
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public double Rate { get; set; }
        public string Specialization { get; set; }
    }
}
