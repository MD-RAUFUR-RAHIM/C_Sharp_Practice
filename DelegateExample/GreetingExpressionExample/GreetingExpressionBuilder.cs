using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreetingExpressionExample
{
    public class GreetingExpressionBuilder
    {
        public Func<string, string?> ConcatGreetingExpression()
        {
            var personParameter = Expression.Parameter(typeof(string), "personName");
            var isNullOrWhiteSpaceMethod = typeof(string).GetMethod(nameof(string.IsNullOrWhiteSpace));

            var condition = Expression.Not(
                Expression.Call(
                    isNullOrWhiteSpaceMethod, personParameter));

            //var trueClause = Expression.Add(
            //    Expression.Constant("Greetings, "), personParameter
            //    );

            var trueClause = Expression.Call(
                typeof(string).GetMethod("Concat", new Type[] { typeof (string), typeof(string) }),
                Expression.Constant("Greetings, "),
                personParameter
                );

            var falseClause = Expression.Constant(null, typeof(string));

            var conditional = Expression.Condition(condition, trueClause, falseClause);

            var lambda = Expression.Lambda<Func<string, string?>>(conditional, personParameter);
            return lambda.Compile();

        }
    }
}
