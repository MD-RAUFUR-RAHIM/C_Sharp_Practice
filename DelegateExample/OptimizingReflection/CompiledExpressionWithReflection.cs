using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OptimizingReflection
{
    public class CompiledExpressionWithReflection
    { 
        private static MethodInfo ExecuteMethod { get; } = typeof(Command)
            .GetMethod("Execute", BindingFlags.NonPublic | BindingFlags.Instance);
        private static Func<Command, int> Impl { get; }
        #region Explanation
        //This code dynamically creates and compiles a lambda expression that efficiently calls 
        //    the private `Execute` method of the `Command` class. 
        //    It first defines a parameter(`instance`) of type `Command`, then creates an expression(`call`) 
        //    that represents calling `Execute` on that instance.Finally, 
        //    it builds a lambda expression(`Func<Command, int>`) and compiles it into a delegate, storing it in `Impl`.
        //        This approach is **much faster** than traditional reflection (`Invoke()`) 
        //    because it generates optimized code at runtime, avoiding method lookup overhead. 
        #endregion
        static CompiledExpressionWithReflection()
        {
            var instance = Expression.Parameter(typeof(Command));
            var call = Expression.Call(instance, ExecuteMethod);
            Impl = Expression.Lambda<Func<Command, int>>(call, instance).Compile();
        }
        public static int CallExecute(Command command) => Impl(command);
    }
}
