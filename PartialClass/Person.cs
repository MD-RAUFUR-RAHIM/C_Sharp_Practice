using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Person
    {
        public string Name { get; set; }
        public void Talk(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
