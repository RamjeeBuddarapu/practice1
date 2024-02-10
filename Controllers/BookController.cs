using BookServiceWEBAPI.Entities;
using BookServiceWEBAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController()
        {
            bookService = new BookService();
        }

        [HttpGet, Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            try
            {
                List<Book> books = bookService.GetAllBooks();
                return StatusCode(200, books); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        

        [HttpGet, Route("GetBookById/{Id}")]
        public IActionResult GetBookById(int Id)
        {
            try
            {
                List<Book> books = bookService.GetBookById(Id);
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost, Route("AddBook")]
        public IActionResult Add([FromBody] Book book)
        {
            try
            {
                bookService.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut, Route("EditBook")]
        public IActionResult Edit(Book book)
        {
            try
            {
                bookService.EditBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete, Route("DeleteBook/{bookId}")]
        public IActionResult Delete(int bookId)
        {
            try
            {
                bookService.DeleteBook(bookId);
                return StatusCode(200, new JsonResult($"Book with Id {bookId}"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

