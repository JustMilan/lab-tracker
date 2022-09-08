namespace lab_tracker.Models.domain
{
    public class Matrix
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
        public IEnumerable<AssignmentStudentStatus> AssignmentStudentStatuses { get; set; }

    }
}
