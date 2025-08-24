// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
User user = new User();
user.GenerateId();
Member member = new Member();
member.GenerateId();
User user2 = new Member();
user2.GenerateId();
Console.WriteLine("Without Virtual");
user.GenerateId2();
member.GenerateId2();
user2.GenerateId2();