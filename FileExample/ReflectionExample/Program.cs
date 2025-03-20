// See https://aka.ms/new-console-template for more information
using ReflectionExample;
using System.Reflection;

Console.WriteLine("Hello, World!");
Type type = typeof(Person);
Person p  = new Person();
Type t2 = p.GetType();
MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
foreach (MethodInfo m in methods)
{
    Console.WriteLine(m.Name);
}
ConstructorInfo defaultConstructor = type.GetConstructor(new Type[] {});
Person person = (Person)defaultConstructor.Invoke(new object[] {  });

MethodInfo talkMethod = type.GetMethod("Talk",BindingFlags.Instance | 
    BindingFlags.NonPublic, new Type[] { typeof(string) });
talkMethod.Invoke(person, new object[] {"Hello Person"});

MethodInfo walkMethod = type.GetMethod("Walk", BindingFlags.Instance |
    BindingFlags.Public, new Type[] { typeof(int) });

walkMethod.Invoke(person, new object[] { 10 });
