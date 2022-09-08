using System.ComponentModel.DataAnnotations;

namespace lab_tracker.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<string> AssignmentStatus = new List<string>();
    }
}
