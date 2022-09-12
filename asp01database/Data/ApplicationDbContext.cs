using asp01database.Models;
using Microsoft.EntityFrameworkCore;

namespace asp01database.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Student>().HasData(new Student { StudentId = 1, Firstname = "Otmar", Lastname = "Drtina"});
        }
    }
}
