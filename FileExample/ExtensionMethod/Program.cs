// See https://aka.ms/new-console-template for more information
using ExtensionMethod;

Console.WriteLine("Hello, World!");
string longText = "This is a very very very very very very very long long long long long text";
string shortText =longText.ToShortString(20);
Console.WriteLine(shortText);
