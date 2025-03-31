// See https://aka.ms/new-console-template for more information
using SimpleAggregationCountWithGroup;

List<Person> person = new List<Person>()
    {
    new Person { Name = "Maruf", Age = 26 },   
    new Person { Name = "Tauhid", Age = 25 },  
    new Person { Name = "Araf", Age = 22 },    
    new Person { Name = "Alice", Age = 25 },   
    new Person { Name = "Bob", Age = 30 },     
    new Person { Name = "Charlie", Age = 22 }, 
    new Person { Name = "David", Age = 35 },   
    new Person { Name = "Eve", Age = 2 },     
    new Person { Name = "Andrew", Age = 25 },  
    new Person { Name = "Sophia", Age = 2 },   
    new Person { Name = "Liam", Age = 10 },    
    new Person { Name = "Noah", Age = 17 },   
    new Person { Name = "Mia", Age = 65 },     
    new Person { Name = "James", Age = 65 },   
    new Person { Name = "Olivia", Age = 85 }
    };
var groupedByAge = person.GroupBy(person =>
    person.Age).Select(group => new
    {
        Age = group.Key,
        Count = group.Count()
    }).OrderBy(person => person.Age);

Console.WriteLine("Ordered People List");
Console.WriteLine("--------------------");
foreach (var group in groupedByAge)
{
    Console.WriteLine($"Age: {group.Age}, Count: {group.Count}");
}
Console.WriteLine();


var youngestOfAll = person.Min(p => p.Age);
var eldestOfAll = person.Max(p => p.Age);
var youngestPerson = person.Where(p => p.Age == person.Min(p => p.Age));
var eldestPerson = person.OrderBy(person => person.Age).Last();

//Console.WriteLine($"Youngest Person of All {youngestPerson.Name} is {youngestOfAll} years old");
Console.WriteLine($"Eldest Person of All {eldestPerson.Name} is {eldestOfAll} years old");
Console.WriteLine();

var groupedByAgeSum = person.GroupBy(person =>
person.Age).Select(group => new
{
    Age = group.Key,
    TotalAge = group.Sum(p => p.Age),
    AverageAge = group.Average(p => p.Age),
    Count = group.Count()
}).OrderBy(person => person.Age);

Console.WriteLine("Ordered People List With Age | Count | Average Age | Total Age");
Console.WriteLine("--------------------");
foreach (var group in groupedByAgeSum)
{
    Console.WriteLine($"Age: {group.Age} Count: {group.Count} Average Age: {group.AverageAge} Total Age: {group.TotalAge}");
}