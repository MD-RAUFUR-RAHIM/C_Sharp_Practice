using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Dog is Eating"); 
        }

        public void MakeSound()
        {
            Console.WriteLine("The Dog is barking");
        }
    }
}
