using LibraryProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data
{
    public class LbContext : DbContext
    {
        public LbContext(DbContextOptions<LbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
