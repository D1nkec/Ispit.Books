using Microsoft.AspNetCore.Identity;

namespace Ispit.Books.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Book> Books { get; set; }
    }
}
