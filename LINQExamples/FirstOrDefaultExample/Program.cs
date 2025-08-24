List<int> numbers = new List<int> { 1, 3, 5, 7, 8, 11, 2 , 6 };

var fistNumberInList = numbers.FirstOrDefault();
Console.WriteLine("First Number of List: " + fistNumberInList);

var firstEven = numbers.FirstOrDefault(num => num % 2 == 0);
if (firstEven != 0)
    Console.WriteLine("The first even number is: " + firstEven);
else
    Console.WriteLine("No Even Number was found");

List<string> name = new List<string> { "Abdullah", "Abu Bakar", "Muhammad", "Umar" };
var firstNameWithA = name.FirstOrDefault(name => name.StartsWith('A'));
Console.WriteLine(firstNameWithA);