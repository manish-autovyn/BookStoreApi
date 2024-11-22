using _02._BookStore_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _02._BookStore_API.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBooksById(int bookId);

        Task<int> AddBookAsync(BookModel bookModel);
    }
}
