using lab_tracker.Data;
using System.ComponentModel.DataAnnotations;

namespace lab_tracker.Models
{

    public class Student
    {
        
        public Student()
        {
            
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
