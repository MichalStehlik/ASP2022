using System.ComponentModel.DataAnnotations;

namespace asp06nmui.Model
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "Every artist must have firstname!")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Every artist must have lastname!")]
        public string Lastname { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
