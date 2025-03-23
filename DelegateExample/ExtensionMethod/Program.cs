// See https://aka.ms/new-console-template for more information
using ExtensionMethod;

Console.WriteLine("Hello, World!");
Person person = new Person();
person.Id = 101;
person.Name = "Maruf";
person.Address = "Tangail";
string info = person.GetInfo();
Console.WriteLine(info);
