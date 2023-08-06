using Microsoft.EntityFrameworkCore;

namespace BookList_MVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
