using System.ComponentModel.DataAnnotations;

namespace asp06nmui.Model
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie must have title!")]
        public string Title { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
