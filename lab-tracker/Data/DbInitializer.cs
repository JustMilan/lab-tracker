using lab_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_tracker.Data
{

    public static class DbInitializer
    {

        public static void Initialize(lab_trackerContext context)
        {
            context.Database.EnsureCreated();
            if (context.Student.Any())
            {
                return;
            }

            Assignment assignment1 = new Assignment();
            assignment1.Name = "opdracht1";

            Assignment assignment2 = new Assignment();
            assignment2.Name = "opdracht2";

            Assignment assignment3 = new Assignment();
            assignment3.Name = "opdracht3";

            context.Assignment.Add(assignment1);
            context.Assignment.Add(assignment2);
            context.Assignment.Add(assignment3);
            context.SaveChanges();

            

            Student mockStudent1 = new Student();
            mockStudent1.Name = "pietje";


            Student mockStudent2 = new Student();
            mockStudent2.Name = "janus";

            context.Student.Add(mockStudent1);
            context.Student.Add(mockStudent2);
            context.SaveChanges();


            AssignmentStudentStatus mockAssignmentStudentStatus = new AssignmentStudentStatus();
            mockAssignmentStudentStatus.status = AssignmentStudentStatus.Status.Help;
            mockAssignmentStudentStatus.StudentId = mockStudent2.Id;
            mockAssignmentStudentStatus.AssignmentId = assignment1.Id;
            context.AssignmentStudentStatus.Add(mockAssignmentStudentStatus);
            context.SaveChanges();
        }
    }

}
