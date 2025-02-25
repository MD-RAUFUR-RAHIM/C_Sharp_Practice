int? x = null;
if (true)
{
    x = 0;
}
else
{
    x = 1;
}
if(x.HasValue)
    Console.WriteLine(x.Value);

int r = x ?? 5;
x ??= 5;