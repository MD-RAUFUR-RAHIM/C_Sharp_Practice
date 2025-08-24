// See https://aka.ms/new-console-template for more information
using ReflectionExample;
using System.Reflection;

Console.WriteLine("Hello, World!");
Student student = new Student();
var studentTypeInfo = typeof(Student);
string assemblyName= studentTypeInfo.Assembly.FullName;
Console.WriteLine(assemblyName);
var getMethods =  studentTypeInfo.GetMethods();
foreach(var method in getMethods)
{
    Console.WriteLine("Method Name : "+ method.Name+"   " +"Return Type: " +method.ReturnType);
}

var properties = studentTypeInfo.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
foreach(var property in properties)
{
    Console.WriteLine(property.Name);
}