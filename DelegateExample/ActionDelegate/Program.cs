class Program
{ 
    static void Main(string[] args)
    {
        Action<int, int> calculateHandeler = Add;
        calculateHandeler(23, 34);
        //Anonymous Method
        Action<int, int> calculateHandeler2 = (int x, int y) => Console.WriteLine("The Result is " + (x * y));
        calculateHandeler2(4, 5);
    }
    static void Add(int fNumber, int sNumber)
    {
        int result = fNumber + sNumber;
        Console.WriteLine(result);
    }
}