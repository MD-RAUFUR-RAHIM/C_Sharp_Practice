// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
Func<int, int, int> funcTest = Calculate;
int result = funcTest.Invoke(3, 5);
Console.WriteLine("The Multiplication is " + result);

Func<int , int , int> funcTest2 = (x,y)=> x + y;

int result2 = funcTest2.Invoke(4, 5);
Console.WriteLine("This is from Anonymous Method " + result2);
static int Calculate(int x, int y)
{
    return x * y;
}