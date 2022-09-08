using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_tracker.Models
{
    public class AssignmentStudentStatus
    {
        [Key]
        public int Id { get; set; }


        public enum Status
        {
            Help,
            NotStarted,
            InProgress,
            Done
        }

        public Status status;



        [ForeignKey("AssignmentId")]
        public int AssignmentId;
        [ForeignKey("StudentId")]
        public int StudentId;
    }
}
