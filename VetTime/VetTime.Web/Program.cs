using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VetTime.Data;
using VetTime.Data.Models;
using VetTime.Services;
using VetTime.Services.Interfaces;
using VetTime.Web.Extentions;
using static VetTime.Web.Common.ApplicationConstants;

namespace VetTime.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => 
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric=false;
                options.Password.RequireDigit=false;
                options.Password.RequireLowercase=false;
                options.Password.RequireUppercase=false;
            })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<IVetService, VetService>();
            builder.Services.AddScoped<ISpecializationService, SpecializationService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();   
            app.UseAuthorization();
            app.SeedRole(AdminEmail, AdminRoleName);
            app.SeedRole(VeterinarianEmail, VeterinarianRoleName);

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
