int sum(int a, int b)
{
    return a + b;
}
int x = sum(5, 9);
int y = sum(x, 10);
Console.WriteLine(x);
Console.WriteLine(y);
int nested1(int x, int y)
{
    int nested2(int x,int y)
    {
        return x + y;
    }
    return nested2(x,y)+x+y;
}
int z = nested1(5, 10);
Console.WriteLine(z);
string name = "Md Raufur Rahim";
char c = 'M';
string optimized = string.Empty;
//Console.WriteLine(optimized.CompareTo(c));
