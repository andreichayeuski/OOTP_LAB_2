using System.Data.Entity;

namespace Lab8.Entity
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("BookDB")
        {
        }
        public DbSet<Book> MyBooks { get; set; }
    }
}