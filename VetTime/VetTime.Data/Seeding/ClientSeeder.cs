using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class ClientSeeder
    {
        public static ICollection<Client> GenerateClients()
        {
            List<Client> values = new List<Client>();
            values.Add(new Client()
            {
                Id = new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                FirstName = "Nicole",
                LastName = "Aleksieva",
                NotVisitedCounter = 0,
                UserId= new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
            });
            return values;
        }
    }
}
