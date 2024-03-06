using HayalTest.Models;
using Microsoft.EntityFrameworkCore;

namespace HayalTest.Data
{
    public class HayalTestDbContext : DbContext
    {
        public HayalTestDbContext(DbContextOptions<HayalTestDbContext> options)
            : base(options)
        {
        }

        // DbSet representing the Book table
        public DbSet<Book> Books { get; set; }
    }
}
