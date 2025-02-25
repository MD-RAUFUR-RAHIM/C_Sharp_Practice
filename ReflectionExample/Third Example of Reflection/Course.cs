using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Third_Example_of_Reflection
{
    public class Course
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public void start()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine($"The Title is {Title}");
        }
        public void stop(int? id , string gg) 
        {
            
            int? x = id * id;
            Console.WriteLine("The Multiplication of Id is : " + x);
            Console.WriteLine("The Default value: " + gg); 
        }
        public void Value(List<string> hobbies)
        {
            Console.WriteLine("Hobby");
        }
    }
}
