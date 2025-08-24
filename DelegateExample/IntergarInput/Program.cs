// See https://aka.ms/new-console-template for more information
Console.WriteLine("Example of User Integar Input");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("This input is taken using Basic Mode " + x);
if (int.TryParse(Console.ReadLine(), out int y))
{
    Console.WriteLine("This input is taken using Safer Mode " + y);
}
else
{
    Console.WriteLine("Invalid Input");
}


Console.ReadKey();