using Microsoft.AspNetCore.Identity;

namespace BlazorApp3.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser(): base() { }
        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> ClaimTypes { get; set; }
    }

}
