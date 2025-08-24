// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Sum(int a, int b)
{ 
    return a + b; 
}    
int Sum2(int a, int b)  => a + b;
Func<int, int, int> x = (int a, int b) => a + b;// annonimous function
int[] p = new int[20];
p.Where(x => x > 0);