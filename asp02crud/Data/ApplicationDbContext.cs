using asp02crud.Model;
using Microsoft.EntityFrameworkCore;

namespace asp02crud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Book>().HasData(new Book { 
                BookId = 1, 
                Title = "Babička", 
                Pages = 100});
        }
    }
}
