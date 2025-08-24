// See https://aka.ms/new-console-template for more information
using LinqExample;

Console.WriteLine("Hello, World!");
List<Course> courses = new List<Course>();
courses.Add(new Course() { Id= 1, Fees= 2000, Title= "C#"});
courses.Add(new Course() { Id = 2, Fees = 3000, Title = "Java" });
courses.Add(new Course() { Id = 3, Fees = 50000, Title = "Python" });
List<Student> students = new List<Student>();
students.Add(new Student() { Id=1,Name = "Maruffuddin", CourseId = 2});
students.Add(new Student() { Id = 2, Name = "Sumaiyuddin", CourseId = 2 });
students.Add(new Student() { Id = 3, Name = "Tauhid", CourseId = 3 });
var query = from s in students
            join c in courses on s.CourseId equals c.Id
            select (name: s.Name, fees: c.Fees,Titles: c.Title);

var name= (from q in query
            where q.fees > 5000
            select q.Titles).FirstOrDefault();
Console.WriteLine(name);