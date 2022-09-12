using System.ComponentModel.DataAnnotations;

namespace asp01database.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Firstname { get; set; } = String.Empty;
        public string Lastname { get; set; } = String.Empty;
    }
}
