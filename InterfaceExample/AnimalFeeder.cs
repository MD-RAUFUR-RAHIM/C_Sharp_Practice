using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class AnimalFeeder
    {
        private readonly IAnimal _animal;
        public AnimalFeeder(IAnimal animal)
        {
            _animal = animal;
        }
    }
}
