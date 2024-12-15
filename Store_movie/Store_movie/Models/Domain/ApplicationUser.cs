using Microsoft.AspNetCore.Identity;

namespace Store_movie.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
