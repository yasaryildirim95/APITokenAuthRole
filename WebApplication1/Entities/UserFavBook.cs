using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Entities
{
    public class UserFavBook
    {
        // Composite key to represent the many-to-many relationship
        public string UserId { get; set; }
        public int BookId { get; set; }

        // Navigation properties
        public AppUser User { get; set; }
        public Book Book { get; set; }
    }
}
