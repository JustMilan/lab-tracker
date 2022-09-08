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

        //public virtual ICollection<Assignment> assignments { get; set; }

        //public Student()
        //{
        //    //this.assignments = new HashSet<Assignment>();
        //}
    }
}
