using System;

public delegate void PrintHandle(string info);
public delegate void PrintMessage(string info, string info2);

class Program
{
    static void Main(string[] args)
    {
        PrintHandle printHandle = Hello;
        printHandle += Goodbye;
        printHandle("John");
        printHandle -= Hello;
        printHandle("Doe");

        PrintMessage printMessage1 = PrintMessage;
        PrintMessage printMessage2 = PrintMessage2;
        PrintMessage printMessage3 = printMessage1 + printMessage2;
        printMessage3("Delegate", " Catenation");
    }

    static void Hello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Goodbye(string name)
    {
        Console.WriteLine("Good bye " + name);
    }
    static void PrintMessage(string message, string message2) 
    {
        Console.WriteLine("This is the example of " +message + message2);
    }
    static void PrintMessage2(string message, string message2) { 
     Console.WriteLine("This is the example of " + message + message2);
    }
}