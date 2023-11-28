using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class ApplicationDbContext : IdentityDbContext <AppUser,AppRole,string>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<UserFavBook> FavBooks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            const string ROLE_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f445";

            modelBuilder.Entity<UserFavBook>()
                .HasKey(ufb => new { ufb.UserId, ufb.BookId });

            modelBuilder.Entity<UserFavBook>()
                .HasOne(ufb => ufb.User)
                .WithMany(u => u.UserFavBooks)
                .HasForeignKey(ufb => ufb.UserId);

            modelBuilder.Entity<UserFavBook>()
                .HasOne(ufb => ufb.Book)
                .WithMany(b => b.UserFavBooks)
                .HasForeignKey(ufb => ufb.BookId);

            modelBuilder.Entity<AppRole>()
                .HasData(new AppRole
                {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });

            
        }




    }
}
