using Microsoft.AspNetCore.Identity;
using VetTime.Data.Models;


namespace VetTime.Web.Extentions
{
    public static class ApplicationBuilderExtentions
    {
        public static IApplicationBuilder SeedRole(this IApplicationBuilder app, string email, string roleName)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopedServices.ServiceProvider;

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole<Guid>> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(roleName))
                {
                    return;
                }

                IdentityRole<Guid> role =
                    new IdentityRole<Guid>(roleName);

                await roleManager.CreateAsync(role);

                ApplicationUser adminUser =
                    await userManager.FindByEmailAsync(email);

                await userManager.AddToRoleAsync(adminUser, roleName);
            })
            .GetAwaiter()
            .GetResult();

            return app;
        }
    }
}
