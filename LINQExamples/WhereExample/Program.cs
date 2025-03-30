// See https://aka.ms/new-console-template for more information
using WhereExample;


List<Person> people = new List<Person>()
{
    new Person(){Name = "Maruf", Age= 26 },
    new Person(){Name = "Tauhid", Age= 25 },
    new Person(){Name = "Araf", Age = 29 },
    new Person { Name = "Alice", Age = 25 },
    new Person { Name = "Bob", Age = 30 },
    new Person { Name = "Charlie", Age = 22 },
    new Person { Name = "David", Age = 35 },
    new Person { Name = "Eve", Age = 20 },
    new Person { Name = "Andrew", Age = 28 }
};
var person = people.Where(p => 
p.Age >= 22 && p.Age <= 30 &&
(p.Name.StartsWith("A") || p.Name.EndsWith("e"))
);
Console.WriteLine("People whose age is between 22 to 30 and Name Start with A or Ends with e");
foreach(var p in person)
{
    Console.WriteLine($"{p.Name} {p.Age} years old");
}