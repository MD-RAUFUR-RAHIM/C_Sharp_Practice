// See https://aka.ms/new-console-template for more information
using GenericOperatorsUsingExpression;

Calculate calculate = new Calculate();
double result = calculate.ThreeFourths(24.5);
Console.WriteLine(result);
int result2 = OptimizedCalculate<int>.Of(10);
Console.WriteLine("This is from Optimized Calculate " + result2);