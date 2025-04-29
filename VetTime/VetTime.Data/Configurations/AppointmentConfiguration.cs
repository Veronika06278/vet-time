using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;
using VetTime.Data.Seeding;

namespace VetTime.Data.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder
                .HasOne(a => a.Client)
                .WithMany(c => c.Appointments)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(AppointmentSeeder.GenerateAppointments());
        }

    }
}
