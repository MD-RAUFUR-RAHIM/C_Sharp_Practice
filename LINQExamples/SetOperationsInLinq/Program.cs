List<int> numbers1 = new List<int> { 1, 2, 3, 4 };
List<int> numbers2 = new List<int> { 3,4, 5,6 };
Console.WriteLine("Union combines two sequences and removes duplicates.");
var unionNumbers = numbers1.Union(numbers2);
Console.WriteLine("After combining and removing duplicates form two sequences " + string.Join(",", unionNumbers));
Console.WriteLine();

Console.WriteLine("Intersect finds the common elements between two sequences.");
var commonNumbers = numbers2.Intersect(numbers1);
Console.WriteLine("After finding the common element between two sequences using Intersect " +string.Join(",", commonNumbers));
Console.WriteLine();

Console.WriteLine("Except finds elements that are in one sequence but not in another.");
var differentNumbers = numbers2.Except(numbers1);
Console.WriteLine("After finding the elements that are in one sequence but not in another. " + string.Join(",", differentNumbers));
Console.WriteLine();
