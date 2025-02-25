// See https://aka.ms/new-console-template for more information
using EntityExample;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
TrainingDbContext context = new TrainingDbContext();
//context.Courses.Add(new Course { Name = "C#", Fees = 2000, IsActive = true, ClassStartDate = DateTime.Now });
//context.Courses.Add(new Course { Name = "Asp Dot Net", Fees = 3232, IsActive = true, ClassStartDate = DateTime.Now });
//context.Students.Add(new Student { Name = "Maruf", CGPA = 3.8 });
//context.SaveChanges();

//Course course = context.Courses.Where(x => x.Id == 3).FirstOrDefault();
//Console.WriteLine(course.Name);
//course.Name = "CSharp";
//context.SaveChanges();

//if (course?.CourseTopics == null)
//    course.CourseTopics = new List<Topic>();

//course?.CourseTopics?.AddRange(new Topic[]
//{
//    new Topic{ Title = "Getting Started"},
//    new Topic{ Title = "Tool Started"}
//});

//context.SaveChanges();

//if (course != null && course.CourseTopics != null)
//{
//    course.CourseTopics = new List<Topic>();
//    Topic topic1 = new Topic();
//    topic1.Title = "Getting Started";

//    Topic topic2 = new Topic();
//    topic2.Title = "Tool Installation";

//    course.CourseTopics.Add(topic1);
//    course.CourseTopics.Add(topic2);
//}

Course course1 = context.Courses.Where(x => x.Id == 3)
    .Include(y => y.CourseTopics).FirstOrDefault();
foreach (var topic in course1.CourseTopics)
    Console.WriteLine(topic.Title);

Course c1 = new Course()
{
    Name = "Devops",
    Fees = 2000,
    IsActive = true,
    ClassStartDate = DateTime.Now,
    CourseTopics = new List<Topic>
    {
        new Topic {Title = "Docker"},
        new Topic {Title = "AWS"}
    },
    CourseStudents = new List<CourseStudent>
    {
        new CourseStudent { Student = new Student {Name =" Maruf Khan ", CGPA = 4.00 } },
        new CourseStudent { Student = new Student {Name =" Tauhid Khan ", CGPA = 4.00 } }
    }
};
context.Courses.Add(c1);
context.SaveChanges();