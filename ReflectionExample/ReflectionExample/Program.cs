using System.Reflection;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
string config = File.ReadAllText(directoryInfo.GetFiles()
    .Where(x => x.Name.Contains("config")).First().FullName);
dynamic configJson = JsonConvert.DeserializeObject(config);
Type t =Assembly.GetExecutingAssembly().GetTypes()
    .Where(x => x.Name == configJson.ClassName.ToString() && x.GetInterface("IPlugin") != null).First();
Console.WriteLine(t.Name);

ConstructorInfo constructor = t?.GetConstructor(new Type[] {typeof(string) });
object o =constructor?.Invoke(new object[] { "Demo Report" });
MethodInfo method = t?.GetMethod("Start", new Type[] {  });
method?.Invoke(o, new object[] { });
