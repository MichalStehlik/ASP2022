using asp03tables.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace asp03tables.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>().HasKey(r => new { r.MovieId, r.ActorId });

            builder.Entity<Genre>().HasData(new Genre
            {
                GenreId = 1,
                Text = "Sci-Fi"
            });
            builder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 1,
                Name = "Avatar",
                GenreId = 1
            });
            builder.Entity<Actor>().HasData(new Actor
            {
                ActorId = 1,
                Name = "Sam Worthington"
            });
            builder.Entity<Role>().HasData(new Role
            {
                ActorId = 1,
                MovieId = 1,
                Name = "Igor"
            });
        }
    }
}
