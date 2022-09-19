using System.ComponentModel.DataAnnotations;

namespace asp01database.Models
{
    public class Student
    {
        public int StudentId { get; set; } // Id
        public string Firstname { get; set; } = String.Empty;
        public string Lastname { get; set; } = String.Empty;
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
