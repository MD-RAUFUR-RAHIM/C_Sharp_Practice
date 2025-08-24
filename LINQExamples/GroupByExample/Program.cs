using GroupByExample;

List<Person> people =  new List<Person>()
{
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 25 },
            new Person { Name = "David", Age = 35 },
            new Person { Name = "Eve", Age = 30 }
};
var groupByAge = people.GroupBy(person => person.Age);
foreach(var group in  groupByAge)
{
    Console.WriteLine($"Age Group: {group.Key}");
    foreach (var person in group)
    {
        Console.WriteLine($"  {person.Name}");
    }
}
var names = people.Select(person => person.Name);
Console.WriteLine();
Console.WriteLine("Using Select to Transform Data");
Console.WriteLine("------------------------------");
foreach (var name in names)
{
    Console.WriteLine(name);
}