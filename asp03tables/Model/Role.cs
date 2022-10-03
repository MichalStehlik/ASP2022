using System.ComponentModel.DataAnnotations;

namespace asp03tables.Model
{
    public class Role
    {
        [Key]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        [Key]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string Name { get; set; }
    }
}
