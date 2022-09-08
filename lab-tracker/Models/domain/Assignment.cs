namespace lab_tracker.Models;

public class Assignment
{
    private string Name { get; set; }
    private AssignmentStatus Status { get; set; }

    public Assignment(string name, AssignmentStatus status = AssignmentStatus.NotStarted)
    {
        this.Name = name;
        this.Status = status;
    }
}