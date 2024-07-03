using Microsoft.AspNetCore.Identity;

namespace LibraryManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
