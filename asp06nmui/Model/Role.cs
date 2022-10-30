using System.ComponentModel.DataAnnotations;

namespace asp06nmui.Model
{
    public class Role
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        [Required(ErrorMessage = "Role name was not specified!")]
        public string Name { get; set; }
    }
}
