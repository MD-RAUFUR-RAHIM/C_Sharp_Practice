
using AnonymousTypesWithSelect;


List<Person> people = new List<Person>()
{
    new Person { Name = "Maruf", Age = 26 },   // Adult
    new Person { Name = "Tauhid", Age = 25 },  // Adult
    new Person { Name = "Araf", Age = 29 },    // Adult
    new Person { Name = "Alice", Age = 15 },   // Teen
    new Person { Name = "Bob", Age = 30 },     // Adult
    new Person { Name = "Charlie", Age = 22 }, // Adult
    new Person { Name = "David", Age = 35 },   // Adult
    new Person { Name = "Eve", Age = 20 },     // Adult
    new Person { Name = "Andrew", Age = 58 },  // Middle-aged
    new Person { Name = "Sophia", Age = 2 },   // Infant
    new Person { Name = "Liam", Age = 10 },    // Child
    new Person { Name = "Noah", Age = 17 },    // Teen
    new Person { Name = "Mia", Age = 45 },     // Middle-aged
    new Person { Name = "James", Age = 65 },   // Senior
    new Person { Name = "Olivia", Age = 85 }   // Elderly
};

var peopleCategories = people.Select(
    person => new
    {
        person.Name,
        Category =  person.Age <13 ? "Child" : 
                    person.Age < 20 ? "Teen" :
                    person.Age < 25 ? "Young" :
                    person.Age < 40 ? "Adult" : 
                    person.Age < 50 ? "Middle Aged" :"Senior"
    });
Console.WriteLine("Person with Age category");
foreach(var p in  peopleCategories)
{
    Console.WriteLine($"{p.Name} - {p.Category} ");
}

var groupByCategory = people.Select(
    person => new
    {
        person.Name,
        Category = person.Age < 13 ? "Child" :
        person.Age < 20 ? "Teen" :
        person.Age < 25 ? "Young" :
        person.Age < 40 ? "Adult" :
        person.Age < 50 ? "Middle Aged" : "Senior"
    }).GroupBy(person =>person.Category);
Console.WriteLine();
Console.WriteLine("People Grouped by Category");
Console.WriteLine("----------------------------");
foreach(var group in groupByCategory)
{
    Console.WriteLine($"Grouped by {group.Key}");
    foreach(var person in group)
    {
        Console.WriteLine($"  - {person.Name}");
    }
}