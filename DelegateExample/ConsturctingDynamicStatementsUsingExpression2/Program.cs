// See https://aka.ms/new-console-template for more information
using ConsturctingDynamicStatementsUsingExpression2;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
Expression paramA = Expression.Call(typeof(Console).GetMethod("ReadLine"));
Expression paramB = Expression.Constant("From Dynamic Statement 2");
var createStatementBlock = new CreateStatementBlock();
var block =createStatementBlock.DynamicStatmentBlock(paramA, paramB);
var lambda = Expression.Lambda<Action>(block).Compile();
lambda();
