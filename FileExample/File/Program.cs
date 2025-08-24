// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
FileStream fs1 = File.Create("ExFile.txt");
using (StreamWriter sw = new StreamWriter(fs1))
{
    sw.WriteLine("Hello World");
}
fs1.Close();
FileStream fs2 = File.Create("ExFile2.txt", 10);
fs2.Close();
FileStream fs3 = File.Create("ExFile3.txt", 10, FileOptions.None);

//File.Copy("ExFile.txt", "ExFileCopy.txt");
using (StreamWriter writer = new StreamWriter("ExFile2.txt", append: true))
{
    writer.WriteLine("Hello Brother. How are you?");
    Console.WriteLine($"File '{fs2}' has been created and written successfully.");
}

//File.CreateText("ExFile.txt");
File.WriteAllText("ExFile.txt", "This is the example of WriteAllText2");
File.WriteAllText("ExFile.txt", "This is the second example", Encoding.UTF8);
File.WriteAllTextAsync("ExFile.txt", "This is the third Example", Encoding.UTF8, CancellationToken.None);
//FileInfo fileInfo = new FileInfo();


