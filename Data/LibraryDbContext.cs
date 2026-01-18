using Microsoft.EntityFrameworkCore;
using Mini_Library_Management.Models.Domain;

namespace Mini_Library_Management.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<BorrowItem> BorrowItems { get; set; }
    }
}
