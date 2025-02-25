// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
Expression<Func<int,bool>> myExpression = a  =>  a% 2 == 0;
Func<int,bool> myFunction = myExpression.Compile();