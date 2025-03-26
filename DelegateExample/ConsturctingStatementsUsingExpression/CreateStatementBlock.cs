using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsturctingStatementsUsingExpression
{
    public class CreateStatementBlock
    {
        public Expression StateMentBlock()
        { 
            var consoleWriteMethod = typeof(Console)
                .GetMethod(nameof(Console.Write), new Type[] {typeof(string) });
            
            var consoleWriteLineMethod = typeof(Console)
                .GetMethod(nameof(Console.WriteLine), new Type[] { typeof(string) });

            return Expression.Block(
                Expression.Call(consoleWriteMethod, Expression.Constant("Hello ")),
                Expression.Call(consoleWriteLineMethod, Expression.Constant("World!"))
                );
        }
    }
}
