// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> numbers = new List<int> { 10, 2, 8, 5, 7, 1, 9, 6, 4, 3 };
var orderNumbers = numbers.OrderBy(num => num);
Console.WriteLine("The Sorted Numbers");
Console.WriteLine("---------------");
foreach (var number in orderNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine();
Console.WriteLine("The Even Numbers List");
Console.WriteLine("---------------");
var evenNumbers = from num in orderNumbers
                  where num % 2 == 0
                  select num;
foreach(var num in evenNumbers)
{
    Console.WriteLine(num);
}
Console.WriteLine();
Console.WriteLine("Projecting Data with Select");
Console.WriteLine("---------------");
var squareNumbers = orderNumbers.Select(num => num * num);
foreach(var num in squareNumbers)
{
    Console.WriteLine(num);
}