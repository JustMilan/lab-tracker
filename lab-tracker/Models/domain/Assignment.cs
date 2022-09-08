

using System.ComponentModel.DataAnnotations;

namespace lab_tracker.Models;

public class Assignment
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    //public virtual ICollection<Student> Students { get; set; }

    public Assignment()
    {
        //this.Students = new HashSet<Student>();
    }
}