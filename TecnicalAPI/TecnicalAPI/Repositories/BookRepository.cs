using Microsoft.EntityFrameworkCore;
using TecnicalAPI.Data;
using TecnicalAPI.Models;

namespace TecnicalAPI.Repositories
{
    public class BookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int Id)
        {
            return await _context.Books.FindAsync(Id);
        }

        public async Task<bool> CreateBook(Book book)
        {
            _context.Add(book);

            int createdBook = await _context.SaveChangesAsync();

            return createdBook > 0 ? true : false;
        }

        //public async Task<bool> UpdateBook(Book book)
        //{
        //    _context.Add(book);

        //    int createdBook = await _context.SaveChangesAsync();

        //    return createdBook > 0 ? true : false;
        //}

        //public async Task<bool> DeleteBook(Book book)
        //{
        //    _context.Add(book);

        //    int createdBook = await _context.SaveChangesAsync();

        //    return createdBook > 0 ? true : false;
        //}
    }
}
