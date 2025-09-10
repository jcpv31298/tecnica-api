using Microsoft.AspNetCore.Mvc;
using TecnicalAPI.Models;
using TecnicalAPI.Services;
using TecnicalAPI.Utils;

namespace TecnicalAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BooksController
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetBooks()
        {
            List<Book> books = await _bookService.GetBooks();

            ApiResponse response = new ApiResponse();
            response.success = true;
            response.statusCode = 200;
            response.message = "";
            response.data = books;

            return response;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ApiResponse>> GetBookById(int Id)
        {
            Book book = await _bookService.GetBookById(Id);

            ApiResponse response = new ApiResponse();
            response.success = true;
            response.statusCode = 200;
            response.message = "";
            response.data = book;

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateBook(Book book)
        {
            bool createdBook = await _bookService.CreateBook(book);

            ApiResponse response = new ApiResponse();
            response.success = createdBook == true ? true : false;
            response.statusCode = createdBook == true ? 200 : 500;
            response.message = createdBook == true ? "Book created successfully" : "An error occurred, try again";
            response.data = createdBook == true ? book : null;

            return response;
        }
    }
}
