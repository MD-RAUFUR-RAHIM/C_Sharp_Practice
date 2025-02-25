// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
Stopwatch stopwatch = Stopwatch.StartNew();
void PrintOdd()
{
    for (int i = 0; i < 10; i++)
    {
        if(i % 2 != 0) 
        { 
            Console.WriteLine(i);
        }
    }
}
void PrintEven()
{
    for (int i = 0; i < 100; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

stopwatch.Start();
//PrintEven();
//PrintOdd();
Thread t1 = new Thread(() => PrintEven());
Thread t2 = new Thread(() => PrintOdd());
t1.Start();
t2.Start();
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
int count = 0; 
void Increase(int amount)
{
    object o = 5;
    lock (o)
    {
        count += amount;
    }
}

Thread t3 = new Thread(() => Increase(5));
Thread t4  = new Thread(() => Increase(10));
t3.Start();
t4.Start();