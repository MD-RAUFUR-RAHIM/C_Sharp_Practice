// See https://aka.ms/new-console-template for more information

using OptimizingReflection;


Console.WriteLine("Hello, World!");
Command command = new Command();
//ReflectionNormalApproach reflectionNormalApproach = new ReflectionNormalApproach();
int result =ReflectionNormalApproach.CallExecute(command);
Console.WriteLine("The Result is from Normal Reflection: " +result);

int resutl2 = ReflectionCached.CallExecute(command);
Console.WriteLine("The Result is from Cached Reflection: " + resutl2);

int result3= CompiledExpressionWithReflection.CallExecute(command);
Console.WriteLine("The Result is from Compiled Expression With Reflection: " + result3);

