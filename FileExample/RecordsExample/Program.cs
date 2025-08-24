// See https://aka.ms/new-console-template for more information
using RecordsExample;

Console.WriteLine("Hello, World!");
Person p1 = new Person();
p1.Name = "Maruf";
p1.Age = 25;

Person p2 = new Person();
p2.Name = "Khan";
p2.Age = 54;
if (p1 == p2)
    Console.WriteLine("Equal");
else
    Console.WriteLine("Not Equal");