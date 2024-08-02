namespace Bookstore.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Bookstore.Models;
    using Microsoft.AspNetCore.Identity;

    public class BookstoreContext : IdentityDbContext<IdentityUser>
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
