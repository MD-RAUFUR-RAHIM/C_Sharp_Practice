// See https://aka.ms/new-console-template for more information
using GreetingExpressionExample;
Console.WriteLine("Hello, World!");
GreetingExpressionBuilder greetingExpressionExample = new GreetingExpressionBuilder();
var getGreeting = greetingExpressionExample.ConcatGreetingExpression();
Console.WriteLine(getGreeting("Maruf"));