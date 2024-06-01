using System.ComponentModel.DataAnnotations;

namespace Ispit.Books.Models.Dbo
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
