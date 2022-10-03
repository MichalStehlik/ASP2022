namespace asp03tables.Model
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
