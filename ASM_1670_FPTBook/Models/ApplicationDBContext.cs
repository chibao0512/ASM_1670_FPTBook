using Microsoft.EntityFrameworkCore;

namespace ASM_1670_FPTBook.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        // db set
        public DbSet<Book> books { get; set; } 
        public DbSet<Genre> genres { get; set; }
        public DbSet<Publisher> publishers { get; set; }
    }
}
