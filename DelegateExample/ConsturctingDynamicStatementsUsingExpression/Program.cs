using ConsturctingDynamicStatementsUsingExpression;
using System.Linq.Expressions;


CreateStatementBlock createStatementBlock = new CreateStatementBlock();
var block = createStatementBlock.DynamicStateMentBlock();
var lambda = Expression.Lambda<Action>(block).Compile();
lambda();