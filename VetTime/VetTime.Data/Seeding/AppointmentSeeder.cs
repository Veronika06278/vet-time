using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;
using VetTime.Data.Models.Enums;

namespace VetTime.Data.Seeding
{
    public class AppointmentSeeder
    {
        public static ICollection<Appointment> GenerateAppointments()
        {
            List<Appointment> values = new List<Appointment>();
            values.Add(new Appointment()
            {
                Id=new Guid("30ccc388-9956-4f37-bdea-c9c5e466c78c"),
                ClientId=new Guid("b3e77258-dd68-4b24-ae5a-98968d7ec371"),
                VetId=new Guid("e1da8c11-27f5-4a8b-8c22-abec84d1995b"),
                AppointmentType= AppointmentType.PrimaryExamination,
                AppointmentTime = new DateTime(2025,4,28,13,0,0),
                CreatedOn=new DateTime(2025,4,27,13,0,0),
                IsDeleted=false
            });
            return values;
        }

        
    }
}
