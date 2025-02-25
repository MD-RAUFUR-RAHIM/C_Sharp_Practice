// See https://aka.ms/new-console-template for more information
using ParameterModifier;

Console.WriteLine("Hello, World!");
int c = 5;
TestClass testClass = new TestClass();
testClass.Method1(ref c);
Console.WriteLine(c);