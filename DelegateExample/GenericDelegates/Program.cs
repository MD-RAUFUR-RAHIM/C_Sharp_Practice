class Program
{
    public delegate void PrintHandeler<T>(T param);
    static void Main(string[] args)
    {
        PrintHandeler<string> printHandeler = Print;
        printHandeler.Invoke("Hi From Generic Delegate string Example");

        PrintHandeler<int> printHandeler1 = PrintInt;
        printHandeler1.Invoke(25);
    }
    static void PrintInt(int number)
    {
        Console.WriteLine("Hi From Generic Delegate Integar Example " + number);
    }
    static void Print(string message)
    {
        Console.WriteLine(message);
    }
}
