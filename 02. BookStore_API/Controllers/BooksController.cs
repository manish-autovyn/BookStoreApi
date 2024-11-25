using _02._BookStore_API.Models;
using _02._BookStore_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _02._BookStore_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await bookRepository.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await bookRepository.GetBooksById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewBook([FromBody] BookModel bookModel)
        {
            var id = await bookRepository.AddBookAsync(bookModel);
            return CreatedAtAction(nameof(GetBookById), new {
                id = id,
                Controller = "books",
            },id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody] BookModel bookModel, [FromRoute] int id)
        {
            await bookRepository.UpdateBookAsync(id, bookModel);
            
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await bookRepository.UpdateBookPatchAsync(id, bookModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookPatch([FromRoute] int id)
        {
            await bookRepository.DeleteBookAsync(id);

            return Ok();
        }
    }
}
