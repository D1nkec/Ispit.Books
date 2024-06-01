using Ispit.Books.Models.Dbo;

namespace Ispit.Books.Services.Interface
{
    public interface IBookService
    {
        Task<Book> CreateBook(string title, ApplicationUser applicationUser);
        Task<Book> GetBook(int id);
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> UpdateBook(int id, string title, ApplicationUser applicationUser);
        Task<bool> DeleteBook(int id);

    }
}
