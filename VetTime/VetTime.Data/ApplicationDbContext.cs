using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetTime.Data.Models;

namespace VetTime.Data
{
    public class ApplicationDbContext : IdentityDbContext
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-OE48P6N;Database=VetTime;Trusted_Connection=True;");
            }
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Rating>()
                .HasKey(r => new
                {
                    r.VetId,
                    r.ClientId
                });
        }
    }
}
