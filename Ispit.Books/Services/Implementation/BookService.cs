using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ispit.Books.Data;
using Ispit.Books.Models.Dbo;
using Ispit.Books.Services.Interface;
using Microsoft.EntityFrameworkCore;



public class BookService : IBookService
{
    private readonly ApplicationDbContext _context;

    public BookService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Book> CreateBook(string title, ApplicationUser applicationUser)
    {
        var dbo = new Book
        {
            Title = title,
            ApplicationUser = applicationUser,
            Author = await _context.Authors.FirstOrDefaultAsync(),
            Publisher = await _context.Publishers.FirstOrDefaultAsync()
        };

        _context.Books.Add(dbo);
        await _context.SaveChangesAsync();
        return dbo;
    }

    public async Task<Book> GetBook(int id)
    {
        return await _context.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .Include(b => b.ApplicationUser)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await _context.Books
            .Include(b => b.Author)
            .Include(b => b.Publisher)
            .Include(b => b.ApplicationUser)
            .ToListAsync();
    }

    public async Task<Book> UpdateBook(int id, string title, ApplicationUser applicationUser)
    {
        var existingBook = await _context.Books.FindAsync(id);

        if (existingBook == null)
        {
            return null;
        }

        existingBook.Title = title;
        existingBook.ApplicationUser = applicationUser;
        existingBook.Author = await _context.Authors.FirstOrDefaultAsync();
        existingBook.Publisher = await _context.Publishers.FirstOrDefaultAsync();

        await _context.SaveChangesAsync();
        return existingBook;
    }

    public async Task<bool> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);

        if (book == null)
        {
            return false;
        }

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        return true;
    }
}
