using asp06nmui.Model;
using Microsoft.EntityFrameworkCore;

namespace asp06nmui.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(r => new { r.MovieId, r.ArtistId, r.Name });
            });
            /*
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasMany(m => m.Roles).WithOne(r => r.Movie).IsRequired();
            });
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasMany(a => a.Roles).WithOne(r => r.Artist).IsRequired();
            });
            */
            modelBuilder.Entity<Movie>().HasData(new Movie { MovieId = 1, Title = "Top Gun" });
            modelBuilder.Entity<Movie>().HasData(new Movie { MovieId = 2, Title = "Top Gun: Maverick" });
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 1, Firstname = "Tom", Lastname = "Cruise" });
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 2, Firstname = "Val", Lastname = "Kilmer" });
            modelBuilder.Entity<Role>().HasData(new Role { ArtistId = 1, MovieId = 1, Name = "Maverick" });
        }
    }
}
