// See https://aka.ms/new-console-template for more information
using Training;
string connectionString = "Server=DESKTOP-VE3NF6U\\SQLEXPRESS;Database=CSharp;Integrated Security=True;TrustServerCertificate=True;";
DataUtility dataUtility = new DataUtility(connectionString);

var name = Console.ReadLine();
string sql = "delete from Courses where name= @name";

var parameters = new Dictionary<string, object>
{
    {"@name", name }
};
dataUtility.ExecuteSql(sql, parameters);
string query = "select * from Courses";
IList<Dictionary<string, object>> data = dataUtility.ReadData(query,null);
foreach (var item in data)
{
    foreach (var col in item)
    {
        Console.WriteLine($"{col.Key}:{col.Value}, ");
    }
    Console.WriteLine();
}