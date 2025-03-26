using GreetingExpressionExample2;
using System.Linq.Expressions;

var greetingExpression = new GreetingExpression();

// Compile the lambda directly
var greetingsFunc = greetingExpression.Greetings().Compile();

// Test the greeting function with different inputs
Console.WriteLine(greetingsFunc("Alice")); // Should print: Greetings, Alice
Console.WriteLine(greetingsFunc("")); // Should print: (null)
Console.WriteLine(greetingsFunc(null)); // Should print: (null)