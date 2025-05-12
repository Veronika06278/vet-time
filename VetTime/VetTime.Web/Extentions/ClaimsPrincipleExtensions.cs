using System.Security.Claims;
using static VetTime.Web.Common.ApplicationConstants;
namespace VetTime.Web.Extentions
{
    public static class ClaimsPrincipleExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }

        public static bool IsVeterinarian(this ClaimsPrincipal user)
        {
            return user.IsInRole(VeterinarianRoleName);
        }

        public static string GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
