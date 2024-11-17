using Microsoft.EntityFrameworkCore;
using Test_one_page.Domain.Entities;

namespace Test_one_page.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
