using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsturctingDynamicStatementsUsingExpression
{
    public class CreateStatementBlock
    {
        public Expression DynamicStateMentBlock()
        {
            var consoleWriteMethod = typeof(Console)
                .GetMethod(nameof(Console.Write), new Type[] {typeof(string)});
            var consoleWriteLineMethod = typeof(Console)
                .GetMethod(nameof(Console.WriteLine), new Type[] { typeof(string) });
            var variableA = Expression.Variable(typeof(string), "x");
            var variableB = Expression.Variable(typeof(string), "y");

            return Expression.Block(
                new[] { variableA, variableB },
                Expression.Assign(variableA, Expression.Constant("Hello ")),
                Expression.Assign(variableB, Expression.Constant("From Dynamic Statement")),
                Expression.Call(consoleWriteMethod, variableA),
                Expression.Call(consoleWriteLineMethod, variableB)
                );
        }
    }
}
