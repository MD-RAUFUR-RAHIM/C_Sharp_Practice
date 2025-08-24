// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
List<string> names = new List<string>();
names.Add("Md Raufur");
names.Add("Md Tauhid");
names.Add("Saikot");
names.Add("Ebrahim");
Predicate<string> nameSearch = IsCheckName;
var data = names.FindAll(nameSearch);
foreach (var d in data)
{
    Console.WriteLine(d);
}

//Anonymous Example
Predicate<string> nameSearch2 = name => (name.StartsWith("S"));
var data2 = names.FindAll(nameSearch2);
foreach (var item in data2)
{
    Console.WriteLine(item);
}

static bool IsCheckName(string name)
{
    if (name.Contains("Md"))
        return true;
    else
        return false;
}