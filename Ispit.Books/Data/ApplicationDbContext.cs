using Ispit.Books.Models.Dbo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ispit.Books.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string role = "admin";
            string userName = "admin@admin.com";
            string roleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();


            builder.Entity<Author>().HasData(
               new Author { Id = 1, Name = "Author1" },
               new Author { Id = 2, Name = "Author2" },
               new Author { Id = 3, Name = "Author3" },
               new Author { Id = 4, Name = "Author4" },
               new Author { Id = 5, Name = "Author5" }
          
           );

           
            builder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Name = "Publisher1" },
                new Publisher { Id = 2, Name = "Publisher2" },
                new Publisher { Id = 3, Name = "Publisher2" }

            );


         


            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = role,
                NormalizedName = "ADMIN",
                Id = roleId
            });
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                UserName = userName,
                Email = userName,
                NormalizedUserName = userName.ToUpper(),
                NormalizedEmail = userName.ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password12345"),
                SecurityStamp = Guid.NewGuid().ToString("D")
               
               

            });


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            });

        }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

    }
}
