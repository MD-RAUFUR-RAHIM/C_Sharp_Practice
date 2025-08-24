// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
StringBuilder  builder = new StringBuilder();
builder.Append("Hello world").AppendLine().Replace('l', 'm');
Console.WriteLine(builder);
string text = builder.ToString();
for(int i= 0; i<text.Length; i++)
{
    builder[i] = 'C';
    Console.WriteLine(builder[i]);
}