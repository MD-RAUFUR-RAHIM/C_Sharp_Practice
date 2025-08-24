using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericOperatorsUsingExpression
{
    public class Calculate
    {
        public T ThreeFourths<T>(T x)
        {
            var param = Expression.Parameter(typeof(T));
            var three = Expression.Convert(Expression.Constant(3), typeof(T));
            var four = Expression.Convert(Expression.Constant(4), typeof(T));

            var operation = Expression.Divide(Expression.Multiply(three, param), four);
            var lambda =Expression.Lambda<Func<T, T>>(operation, param);

            var func = lambda.Compile();
            return func(x);
        }
    }
}
