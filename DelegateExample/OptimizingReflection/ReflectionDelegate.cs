using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OptimizingReflection
{
    public class ReflectionDelegate
    {
        private static MethodInfo ExecuteMethod { get; } = typeof(Command)
            .GetMethod("Execute", BindingFlags.NonPublic | BindingFlags.Instance);
        #region ExplanationOfCode
        /*private static Func<Command, int> Iml { get; } =
        (Func<Command, int>) Delegate.CreateDelegate(typeof(Func<Command, int>), ExecuteMethod);*/
        //This statement creates a delegate that allows calling the private Execute method in a more optimized way than traditional reflection.
        /*Step-by-Step Breakdown
            1. private static Func<Command, int> Impl { get; }
            Declares a private static property named Impl.

            Its type is Func<Command, int>, which means:

            It takes a Command object as input.

            It returns an int.

            Impl stores a delegate that will allow calling Execute(). */

        /* Delegate.CreateDelegate(typeof(Func<Command, int>), ExecuteMethod)
             Creates a delegate dynamically at runtime.

             The delegate type is Func<Command, int> (i.e., it takes Command and returns int).

             ExecuteMethod is a reference to the MethodInfo of the private Execute method.*/

        /*(Func<Command, int>)
            CreateDelegate(...) returns a general Delegate object.

            We cast it to Func<Command, int> to match our expected function signature.*/
              /*  How Does This Work?
                    Retrieves the Execute method's metadata (ExecuteMethod).

                    Creates a delegate that directly calls Execute without needing Invoke().

                    Stores the delegate in Impl for faster execution.

                    This optimizes reflection by creating a direct delegate for calling Execute().

                    Improves performance by avoiding MethodInfo.Invoke().

                    Impl acts as a function pointer to Execute().*/
        #endregion 
        private static Func<Command, int> Iml { get; } =
            (Func<Command, int>)Delegate.CreateDelegate(typeof(Func<Command, int>), ExecuteMethod);
        public static int CallExecute(Command command)=> Iml(command);
    }
}
