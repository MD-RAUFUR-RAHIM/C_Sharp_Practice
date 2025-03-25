// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
BlockExpression blockExpr = Expression.Block(
    Expression.Call(
        null,
        typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
        Expression.Constant("Hello ")
       ),
    Expression.Call(
        null,
        typeof(Console).GetMethod("WriteLine", new Type[] { typeof(Int32) }),
        Expression.Constant(5)
        ),
    Expression.Constant(42)
);
Console.WriteLine("The result of executing the expression tree:");
// The following statement first creates an expression tree,
// then compiles it, and then executes it.
var result = Expression.Lambda<Func<int>>(blockExpr).Compile()();

// Print out the expressions from the block expression.
Console.WriteLine("The expressions from the block expression:");
foreach (var expr in blockExpr.Expressions)
    Console.WriteLine(expr.ToString());

// Print out the result of the tree execution.
Console.WriteLine("The return value of the block expression:");
Console.WriteLine(result);