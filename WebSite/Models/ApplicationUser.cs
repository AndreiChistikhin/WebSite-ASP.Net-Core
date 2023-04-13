using Microsoft.AspNetCore.Identity;

namespace WebSite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int FullName { get; set; }
    }
}
