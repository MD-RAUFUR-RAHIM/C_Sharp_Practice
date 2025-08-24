using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OptimizingReflection
{
    public class ReflectionNormalApproach
    {
     public static int CallExecute(Command command) => (int) typeof(Command)
            .GetMethod("Execute", BindingFlags.NonPublic | BindingFlags.Instance)
            .Invoke(command, null);
    }
}
