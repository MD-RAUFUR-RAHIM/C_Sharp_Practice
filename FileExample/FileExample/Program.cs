// See https://aka.ms/new-console-template for more information
using System.Text;

//Console.WriteLine("Hello, World!");
//using (StreamWriter writer = File.AppendText("Hello.txt"))
//{
//    writer.WriteLine("This is C#");
//    writer.Close();
//    writer.Dispose();
//}

//{
//  using FileStream fileStream = File.Open("Hello.txt", FileMode.Open);
//    byte[] buffer = new byte[10];
//    fileStream.Read(buffer, 0, 9);
//    string text = Encoding.UTF8.GetString(buffer);
//    Console.WriteLine(text);
//}
//{
//    using FileStream fileStream2 = File.Open("Hello.txt",FileMode.Open);
//    while (true)
//    {
//        int x = fileStream2.ReadByte();
//        if(x < 0) 
//            break;
//        Console.WriteLine((char)x);
//    }
//}
string directory = Directory.GetCurrentDirectory();
DirectoryInfo dir = new DirectoryInfo(directory);
string root = dir.Parent.FullName;
string path = Path.Combine(root, "Hello.txt");
Console.WriteLine(path);
