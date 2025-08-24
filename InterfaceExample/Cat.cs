using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Cat is Eating");
        }

        public void MakeSound()
        {
            Console.WriteLine("The Cat is meowing");
        }
    }
}
