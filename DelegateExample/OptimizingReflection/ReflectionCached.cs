using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OptimizingReflection
{
    public class ReflectionCached
    {
        private static MethodInfo ExecuteMethod { get; } = typeof(Command)
            .GetMethod("Execute", BindingFlags.NonPublic | BindingFlags.Instance);
        public static int CallExecute(Command command1) => 
            (int) ExecuteMethod.Invoke(command1, null);
    }
}
