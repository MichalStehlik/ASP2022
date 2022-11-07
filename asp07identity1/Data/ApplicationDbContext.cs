using asp07identity1.Models;
using Microsoft.EntityFrameworkCore;

namespace asp07identity1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
