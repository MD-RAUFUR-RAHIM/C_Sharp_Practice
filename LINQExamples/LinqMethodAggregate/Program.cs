using LinqMethodAggregate;

var person = new List<Person>
{
    new Person { Name = "Alice" },
    new Person { Name = "Bob" },
    new Person { Name = "Christopher" },
    new Person { Name = "Abdullah", Age = 25 },
    new Person { Name = "Barbossa", Age = 30 },
    new Person { Name = "Charlie", Age = 22 },
    new Person { Name = "Alice", Age = 25 },
};

var longestName = person.Aggregate("", (longest, p) =>
p.Name.Length > longest.Length ? p.Name : longest);

Console.WriteLine($"Longest Number: {longestName}");

var sumOfAges = person.Aggregate(0, (sum, p) => sum + p.Age);
Console.WriteLine("Summation of Ages: " + sumOfAges);

int[] numbers = {1, 2, 3, 3, 4, 4, 4, 5, 10, 22, 23, 24};
var distinctNumbers = numbers.Distinct();
Console.WriteLine("Distinct Numbers: " + string.Join(", " , distinctNumbers));

string[] stringValue = { "Apple", "Apple", "Mango", "Pineapple", "Banana", "Man", "Man" };
var distinctString = stringValue.Distinct();
Console.WriteLine("Distinct String values: " + string.Join(", " , distinctString));
Console.WriteLine();

var distinctPeople = person.Distinct(new PersonComparer());

foreach (var people in distinctPeople)
{
    Console.WriteLine($"{people.Name}, Age: {people.Age}");
}