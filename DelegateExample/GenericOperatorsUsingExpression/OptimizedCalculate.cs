using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericOperatorsUsingExpression
{
    public static class OptimizedCalculate<T>
    {
        public static Func<T, T> Of { get; } = CreateFunction();
        private static Func<T, T> CreateFunction()
        {
            var param = Expression.Parameter(typeof(T));
            var three = Expression.Convert(Expression.Constant(3), typeof(T));
            var four = Expression.Convert(Expression.Constant(4), typeof(T));
            var operation = Expression.Divide(Expression.Multiply(param, three), four);
            return Expression.Lambda<Func<T, T>>(operation, param).Compile();
        }
        public static int x = y;
        private static int y=7;
    }
}
