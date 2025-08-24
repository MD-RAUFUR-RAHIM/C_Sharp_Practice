// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.WriteLine("Hello, World!");
int x = 0;
try
{
    x = GetItem() / GetItemCount();
}
catch (InvalidOperationException e)
{ 

}
catch (DivideByZeroException e)
{
    Console.WriteLine("Divide by zero exception");
}
finally
{
    Console.WriteLine("Finally");
}
int GetItem() => 5;
int GetItemCount() => 0;