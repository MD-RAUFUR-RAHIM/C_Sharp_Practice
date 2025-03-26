using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsturctingDynamicStatementsUsingExpression2
{
    public class CreateStatementBlock
    {
        public Expression DynamicStatmentBlock(Expression paramA, Expression paramB)
        {
            var consoleWriteMethod = typeof(Console)
                .GetMethod(nameof(Console.Write), new Type[] {typeof(string)});

            var consoleWriteLineMethod = typeof(Console)
                .GetMethod(nameof(Console.WriteLine), new Type[] { typeof(string) });

            //var variableA = Expression.Variable(typeof(string), "x");
            //var variableB = Expression.Variable(typeof(string), "y");
            //var variableC = paramA;
            //var variableD = paramB;

            return Expression.Block(   
                Expression.Call(consoleWriteMethod, paramA),
                Expression.Call(consoleWriteLineMethod, paramB)
                );
        }
    }
}
