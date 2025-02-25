// See https://aka.ms/new-console-template for more information
using SecondExampleReflection;
using System.Reflection;

Console.WriteLine("Hello, World!");

//Person person = new Person { Name= "Maruf", Age= 25};
//Type type = person.GetType();
//Console.WriteLine(type.FullName);
//Console.WriteLine(type.Name);
//PropertyInfo[] propertyInfo = type.GetProperties();
//foreach(var  property in propertyInfo)
//{
//    Console.WriteLine($"{property.Name}: {property.PropertyType.Name}");
//}


//PropertyInfo nameProperty = type.GetProperty("Name");
//Console.WriteLine("Original Name: " + nameProperty.GetValue(person));
//nameProperty.SetValue(person, "Alice");
//Console.WriteLine("Updated Name: " + nameProperty.GetValue(person));

Person p2 = new Person();
p2.Name = "Khan";
p2.Age = 25;
p2.Hobbies = new List<string>();
p2.Hobbies.Add("Reading");
p2.Hobbies.Add("Writing");


Type type1 = p2.GetType();
PropertyInfo hobbiesProperty = type1.GetProperty("Hobbies");
Console.WriteLine("The type of Hobbies property is: " + hobbiesProperty.PropertyType.FullName);
Console.WriteLine("Existing Hobbies");
var existingHobbies = (List<string>)hobbiesProperty.GetValue(p2);
foreach(var hobby in existingHobbies)
{
    Console.WriteLine(hobby);
}
Console.WriteLine();

List<string> newhobbies = new List<string> { "Driving", "Swimming" };

hobbiesProperty.SetValue(p2,newhobbies);

var updatedHobbies = (List<string>)hobbiesProperty.GetValue(p2);
foreach (var hobby in updatedHobbies)
{
    Console.WriteLine(hobby);
}
Console.WriteLine();

