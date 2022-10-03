using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp03tables.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}
