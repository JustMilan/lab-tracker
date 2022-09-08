using lab_tracker.Models;

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

            Student mockStudent = new Student();
            mockStudent.Name = "pietje";
            mockStudent.AssignmentStatus = new List<string>() { "done", "wip", "Help" };

            context.Student.Add(mockStudent);

            context.SaveChanges();
        }
    }

}
