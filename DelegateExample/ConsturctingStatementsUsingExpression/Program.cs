// See https://aka.ms/new-console-template for more information
using ConsturctingStatementsUsingExpression;
using System.Linq.Expressions;

CreateStatementBlock createStatementBlock = new CreateStatementBlock();
var block = createStatementBlock.StateMentBlock();
var lambda = Expression.Lambda<Action>(block).Compile();
lambda();