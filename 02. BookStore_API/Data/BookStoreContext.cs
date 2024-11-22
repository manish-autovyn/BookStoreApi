using Microsoft.EntityFrameworkCore;

namespace _02._BookStore_API.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }

    }
}
