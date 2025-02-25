// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("Hello, World!");
//int[] arr = { 5, 343, 3, 5, 6, 1, 2, 9 };
//BubbleSort<int>sort = new BubbleSort<int>();
//var result = sort.Sort(arr, CompareNumber);
//bool CompareNumber(int a, int b)
//{
//    return a > b;
//}
//foreach(var item in result)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
Person[] persons = new Person[4];
persons[0] = new Person() { Name = "Tareq", Age = 25 };
persons[1] = new Person() { Name = "Hasan", Age = 30 };
persons[2] = new Person() { Name = "Tareq", Age = 35 };
persons[3] = new Person() { Name = "Arif", Age= 40 };

BubbleSort<Person> sort2 = new BubbleSort<Person>();
var result2 = sort2.Sort(persons, ComparePerson);

bool ComparePerson(Person person1, Person person2)
{
    if (person1.Name.CompareTo(person2.Name) == 0)
        return person1.Age < person2.Age;
    else
        return person1.Name.CompareTo(person2.Name) > 0;
}
foreach(var item in result2)
{
    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
}
Func<Person, Person, bool> compare = ComparePerson;
Console.WriteLine(compare(persons[0], persons[1]));