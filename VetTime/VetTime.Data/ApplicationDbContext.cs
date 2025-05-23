﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using VetTime.Data.Configurations;
using VetTime.Data.Models;
using VetTime.Data.Seeding;

namespace VetTime.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Veterinarian> Veterinarians { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<VetSpecialization> VetSpecializations { get; set; }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //TODO: Create new migration
            
            builder.ApplyConfiguration<Rating>(new RatingConfiguration());           
            builder.ApplyConfiguration<Appointment>(new AppointmentConfiguration());
            //seeding data
            builder.ApplyConfiguration<ApplicationUser>(new ApplicationUserConfiguration());
            builder.ApplyConfiguration<Client>(new ClientConfiguration());
            builder.ApplyConfiguration<City>(new CityConfiguration());
            builder.ApplyConfiguration<Address>(new AddressConfuration());
            builder.ApplyConfiguration<Veterinarian>(new VeterinarianConfiguration());
            builder.ApplyConfiguration<Specialization>(new SpecializationConfiguration());
            builder.ApplyConfiguration<VetSpecialization>(new VetSpecializationConfiguration());
        }
    }
}
