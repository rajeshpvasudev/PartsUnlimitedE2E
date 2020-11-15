using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    // my changes  by Rajesh
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}