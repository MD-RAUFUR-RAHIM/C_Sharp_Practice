using System.Reflection;
using Third_Example_of_Reflection;

//Course course = new Course() { Id = 1, Title= "This is Course1"};

////Type type  = course.GetType();

////PropertyInfo propertyInfo = type.GetProperty("Title");
////Console.WriteLine("The type of Title Property is: " + propertyInfo.PropertyType.Name);

////PropertyInfo[] propertyInfos = type.GetProperties();
////foreach( var property in  propertyInfos)
////{
////    Console.WriteLine($"{property.Name}: {property.GetValue(course)}" );
////}
////MethodInfo method = type.GetMethod("start");
////Console.WriteLine("Method found: " + method.Name);
////method.Invoke(course,null);

////MethodInfo method2 = type.GetMethod("stop");
////Console.WriteLine("Method found: " + method2.Name);
////object[] parameters = new object[] {5};
////method2.Invoke(course,parameters);

Type type1 = typeof(Course);
object instance = Activator.CreateInstance(type1); // Create an instance dynamically
foreach (var property in type1.GetProperties(BindingFlags.Public | BindingFlags.Instance))
{
    if (property.CanWrite) // Only set properties that are writable
    {
        object defaultValue = GenerateDefaultValue(property.PropertyType);
        property.SetValue(instance, defaultValue);
        Console.WriteLine($"Property: {property.Name}, Set Value: {defaultValue}");
    }
} 
MethodInfo[] methods = type1.GetMethods(
    BindingFlags.Public |
    BindingFlags.Instance |
    BindingFlags.DeclaredOnly
);

foreach (var methodInfo in methods)
{
    if (methodInfo.DeclaringType == typeof(object))
        continue;
    Console.WriteLine(methodInfo.Name);
    if (methodInfo.Name.StartsWith("get_") || methodInfo.Name.StartsWith("set_"))
        continue;
    ParameterInfo[] parameters = methodInfo.GetParameters();
    Console.WriteLine($"Parameter Count: {parameters.Length}");
    object[] dynamicParams = PrepareDynamicParameters(parameters);
    try
    {
        // Invoke the method
        Console.WriteLine("Invoking Method...");

        methodInfo.Invoke(instance, dynamicParams.Length > 0 ? dynamicParams : null);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error invoking {methodInfo.Name}: {ex.Message}");
        Console.WriteLine("   ");
    }
    

}
static object[] PrepareDynamicParameters(ParameterInfo[] parameters)
{
    if (parameters.Length == 0)
        return Array.Empty<object>();

    List<object> dynamicParams = new List<object>();

    foreach (var param in parameters)
    {
        Type paramType = param.ParameterType;
        object paramValue = GenerateDefaultValue(paramType);

        Console.WriteLine($"Parameter: {param.Name}, Type: {paramType.Name}, Generated Value: {paramValue}");
        dynamicParams.Add(paramValue);
    }

    return dynamicParams.ToArray();
}
static object GenerateDefaultValue(Type type)
{

    if (type == typeof(int) || type == typeof(int?))
        return 42;

    if (type == typeof(string))
        return "Generated Value";

    if (type == typeof(bool) || type == typeof(bool?))
        return true;

    if (type == typeof(double) || type == typeof(double?))
        return 3.14;

    if (type == typeof(List<string>))
        return new List<string> { "Item1", "Item2" };

    if (type.IsEnum)
        return Enum.GetValues(type).GetValue(0);

    // For complex types, try to create an instance
    if (!type.IsPrimitive && type != typeof(string))
    {
        try
        {
            return Activator.CreateInstance(type);
        }
        catch
        {
            return null;
        }
    }

    return null;
}







