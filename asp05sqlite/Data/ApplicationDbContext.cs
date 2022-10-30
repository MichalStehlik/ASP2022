using Microsoft.EntityFrameworkCore;

namespace asp05sqlite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
