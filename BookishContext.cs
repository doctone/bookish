using Microsoft.EntityFrameworkCore;
using bookish.Models.Database;

namespace bookish
{
    public class BookishContext : DbContext
    {
        public DbSet<BookDbModel> Books { get; set; }
        public DbSet<AuthorDbModel> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookishDB;Trusted_Connection=True;");
        }
    }
}