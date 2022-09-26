using System.ComponentModel.DataAnnotations;

namespace asp02crud.Model
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; } = String.Empty;
        [Required]
        public int Pages { get; set; } = 0;
    }
}
