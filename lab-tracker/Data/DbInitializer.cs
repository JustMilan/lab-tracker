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
            //User user1 = new User()
            //{
            //    UserId = 1,
            //    FirstName = "Luuk",
            //    LastName = "de Kinderen",

            //    ZipCode = "5386 ja",
            //    HouseNumber = 1,
            //    HouseNumberAddition = null,
            //    StreetName = "D'n ham",
            //    City = "Geffen",
            //    Latitude = 51.7407979,
            //    Longitude = 5.452036
            //};

            //Advertisement advertisement1 = new Advertisement()
            //{

            //    AdvertisementName = "A1",
            //    AdvertisementAmount = 100,
            //    User = user1
            //};

            //var advertisements = new Advertisement[]
            //{
            //    advertisement1
            //};
            //foreach (var advertisement in advertisements)
            //{
            //    context.Advertisements.Add(advertisement);
            //}
            //context.SaveChanges();

            //var users = new User[]
            //{
            //    user1
            //};
            //foreach (var user in users)
            //{
            //    context.Users.Add(user);
            //}
            //context.SaveChanges();
        }
    }

}
