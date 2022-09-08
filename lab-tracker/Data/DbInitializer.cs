using lab_tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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

            var assignment1 = new Assignment
            {
                Name = "opdracht1"
            };

            var assignment2 = new Assignment
            {
                Name = "opdracht2"
            };

            var assignment3 = new Assignment
            {
                Name = "opdracht3"
            };

            context.Assignment.Add(assignment1);
            context.Assignment.Add(assignment2);
            context.Assignment.Add(assignment3);
            context.SaveChanges();


            var mockStudent1 = new Student
            {
                Name = "pietje"
            };

            var mockStudent2 = new Student
            {
                Name = "janus"
            };

            var mockStudent3 = new Student
            {
                Name = "Henk"
            };

            var mockStudent4 = new Student
            {
                Name = "Klaasje"
            };

            context.Student.Add(mockStudent1);
            context.Student.Add(mockStudent2);
            context.Student.Add(mockStudent3);
            context.Student.Add(mockStudent4);
            context.SaveChanges();

            var values = Enum.GetValues(typeof(AssignmentStudentStatus.Status));
            var random = new Random();


            foreach (var student in context.Student)
            {
                foreach (var assignment in context.Assignment)
                {
                    var randomStatus = (AssignmentStudentStatus.Status)values.GetValue(random.Next(values.Length))!;
                    Console.WriteLine(randomStatus);

                    var mockAssignmentStudentStatus1 = new AssignmentStudentStatus
                    {
                        status = randomStatus,
                        StudentId = student.Id,
                        AssignmentId = assignment.Id
                    };

                    context.AssignmentStudentStatus.Add(mockAssignmentStudentStatus1);
                    context.SaveChanges();
                }
            }

            context.SaveChanges();
        }
    }
}