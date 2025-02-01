using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Seeding
{
    public static class ApplicationUserSeeder
    {
        public static ICollection<ApplicationUser> GenerateUsers()
        {
            List<ApplicationUser> values = new List<ApplicationUser>();

            values.Add(new ApplicationUser()
            {
                Id = new Guid("09d568fa-092d-4fce-968b-37eedbdfdbba"),
                UserName = "client@gmail.com",
                NormalizedUserName = "CLIENT@GMAIL.COM",
                Email = "client@gmail.com",
                NormalizedEmail = "CLIENT@GMAIL.COM",
                EmailConfirmed = false,
                SecurityStamp = "5b3e881c-bfe4-43f2-a4d8-e2d28af0293a",
                PhoneNumber = "0886578436",

            });

            values.Add(new ApplicationUser()
            {
                Id = new Guid("2c80bd0d-c688-4ea3-ab33-9eb542b43b4c"),
                UserName = "veterinar@gmail.com",
                NormalizedUserName = "VETERINAR@GMAIL.COM",
                Email = "veterinar@gmail.com",
                NormalizedEmail = "VETERINAR@GMAIL.COM",
                EmailConfirmed = false,
                SecurityStamp = "1e860808-5c39-42fd-ba4a-e71f2286a26c",
                PhoneNumber = "0887564962",
            });

            var hasher = new PasswordHasher<ApplicationUser>();

            foreach (var user in values)
            {
                user.PasswordHash=hasher.HashPassword(user,"123456");
            }



            return values;
        }
    }
}
