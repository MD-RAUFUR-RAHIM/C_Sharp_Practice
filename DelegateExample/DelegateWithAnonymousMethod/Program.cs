public delegate int Calculator(int firstNumber, int secondNumber);
public delegate double Multiplicator(int firstNumber, double secondNumber);
class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = delegate (int x, int y)
                                        {
                                            return x + y;
                                        };
        int result1 = calculator.Invoke(10, 20);
        calculator = delegate (int x, int y)
                        {
                            return x - y;
                        };
        int result2 = calculator.Invoke(10, 20);
        Console.WriteLine("Addition using delegate and anonymous Method " + result1);
        Console.WriteLine("Subtraction using delegate and anonymous Method " + result2);

        //Multiplicator multiplicator = (int x, double y) =>  x * y;
        //We can also use it like this. by default it will take the parameter type as it is defined in the delegate
        Multiplicator multiplicator = (x, y) => x * y;
        double result3 = multiplicator.Invoke(10, 20.12);
        Console.WriteLine("Multiplication using delegate and lambda expression " + result3);
        //Lambda Statement Example
        Multiplicator multiplicator1 = (x, y) =>
        {
            return x * y;
        };
        double result4 = multiplicator1.Invoke(10, 225.912);
        Console.WriteLine("Multiplication using delegate and lambda statement " + result4);
    }
}