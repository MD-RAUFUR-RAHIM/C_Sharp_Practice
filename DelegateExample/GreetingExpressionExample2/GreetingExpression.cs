using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreetingExpressionExample2
{
    public class GreetingExpression
    {
        public Expression<Func<string, string>> Greetings()
        {
            var personNameParameter = Expression.Parameter(typeof(string), "personName");
            var isNullOrWhiteSpaceMethod = typeof(string).GetMethod(nameof(string.IsNullOrWhiteSpace));

            var condition = Expression.Not(
                Expression.Call(isNullOrWhiteSpaceMethod, personNameParameter)
            );

            var trueCluase = Expression.Call(
                typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string) }),
                Expression.Constant("Greetings, "),
                personNameParameter
            );

            var falseClause = Expression.Constant(null, typeof(string));

            return Expression.Lambda<Func<string, string>>(
                Expression.Condition(condition, trueCluase, falseClause),
                personNameParameter
            );
        }
    }
}
