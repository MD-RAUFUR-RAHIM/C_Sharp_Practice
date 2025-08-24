using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionWithAnimalExample
{
    public class AnimalActions
    {
        public static void MakeDogBark()
        {
            Console.WriteLine("The Dog Barks");
        }
        public static void MakeCatMeow() => Console.WriteLine("The Cat Meows");
    }
}
