namespace asp03tables.Model
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Text { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
