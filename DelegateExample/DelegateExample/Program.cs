// See https://aka.ms/new-console-template for more information
using DelegateExample;
using System.Data;
public delegate int AddCalculator(int firstNumber, int secondNumber);

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine("Enter Integar Number");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        AddCalculator addCalculator = Add;
        //int result = addCalculator.Invoke(10, 20);
        //Console.WriteLine(result);

        methodAsParameter(addCalculator, x, y);
        addCalculator = Sub;
        methodAsParameter(addCalculator, x, y);

    }

    static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
    static int Sub(int firstNumber, int secondNumber)
    {
        return firstNumber - secondNumber;
    }
    public static void methodAsParameter(AddCalculator addCalculator, int fNumber, int sNumber)
    {
        int result = addCalculator.Invoke(fNumber, sNumber);
        Console.WriteLine("This result is from methodAsParameter " + result);
    }
}

