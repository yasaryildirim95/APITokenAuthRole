using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<UserFavBook> UserFavBooks { get; set; }

    }
}
