using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Services.Interfaces
{
    public interface IAddressService
    {
        public Guid Add(Guid cityId, string district, string street, int number);
    }
}
