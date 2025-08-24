using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OptimizingReflection
{
    public class BenchMarks
    {
        //Need Futhrer study in future not now

        [Benchmark(Description = "Reflection", Baseline = true)]
        public int Reflection() => (int)typeof(Command)
        .GetMethod("Execute", BindingFlags.NonPublic | BindingFlags.Instance)
        .Invoke(new Command(), null);

        [Benchmark(Description = "Reflection (cached)")]
        public int Cached() => ReflectionCached.CallExecute(new Command());

        [Benchmark(Description = "Reflection (delegate)")]
        public int Delegate() => ReflectionDelegate.CallExecute(new Command());

        [Benchmark(Description = "Expressions")]
        public int Expressions() => CompiledExpressionWithReflection.CallExecute(new Command());
    }
}
