// See https://aka.ms/new-console-template for more information
using CollectionIntializer;
using System.Security.Cryptography;


//Collection Initializer
Student student2 = new Student() { Id = 1, Name = "Tauhid" };
Student student3 = new Student() { Id = 2, Name = "Shoshi" };
List<Student> students = new List<Student>();
students.Add(student2);
students.Add(student3);

foreach (var item in students)
{
    Console.WriteLine("Id: " + item.Id + " " + "Name: " + item.Name);
}

//Collection Initializer 2nd approach
Console.WriteLine();
Console.WriteLine("Collection Initializer 2nd approach");
List<Student> students2 = new List<Student>() { student2, student3};
foreach (var item in students2)
{
    Console.WriteLine("Id: " + item.Id + " " + "Name: " + item.Name);
}


//collecetion Initializer 3rd approach

List<Student> students3 = new List<Student>()
{
    new Student() { Id = 3, Name = "Muhammad"},
    new Student() { Id = 4, Name = "Ahmad" },
    new Student(){Id = 5, Name = "Sumaiya"}
 };
Console.WriteLine();
Console.WriteLine("Collection Initializer 3rd approach");
foreach (var item in students3)
{
    Console.WriteLine("Id: " + item.Id + " " + "Name: " + item.Name);
}
