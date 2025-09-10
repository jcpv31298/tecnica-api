using TecnicalAPI.Models;
using TecnicalAPI.Repositories;

namespace TecnicalAPI.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<List<Book>> GetBooks() => _bookRepository.GetBooks();
        public Task<Book> GetBookById(int Id) => _bookRepository.GetBookById(Id);
        public Task<bool> CreateBook(Book book) => _bookRepository.CreateBook(book);
        //public Task<bool> UpdateBook(Book book) => _bookRepository.CreateBook(book);
        //public Task<bool> DeleteBook(Book book) => _bookRepository.CreateBook(book);
    }
}
