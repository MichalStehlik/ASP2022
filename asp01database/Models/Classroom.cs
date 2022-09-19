namespace asp01database.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
