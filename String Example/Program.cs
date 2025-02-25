string str1 = "Axample2";
string str2 = "Example";
int resutl =string.Compare(str1, str2);
Console.WriteLine(resutl);
string str3 = "apple";
string str4 = "banana";
int result1= string.CompareOrdinal(str3, str4);
string sentence = "Hello World! How are you doing? I am doing fine";
bool containsWord=sentence.Contains("Fine");
Console.WriteLine(containsWord);
string original = "Hello, !";
string inserted = original.Insert(1, "World");
Console.WriteLine(inserted); // Output: "Hello, World!"
string[] emotion = { "anger", "pain", "laughter", "disgustion" };
string joined=string.Join("*", emotion);
Console.WriteLine(joined);
int lastIndex = joined.LastIndexOf("ng");
Console.WriteLine(lastIndex);
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
