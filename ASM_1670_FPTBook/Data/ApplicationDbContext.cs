using ASM_1670_FPTBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASM_1670_FPTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Publisher> publishers { get; set; }
    }
}