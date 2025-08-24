using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Member : User
    {
        public override void GenerateId()
        {
            Console.WriteLine("Generating Id in Member");
            base.GenerateId();
            Console.WriteLine(" ");

        }
        public new void GenerateId2()
        {
            Console.WriteLine("Generating2 Id in Member");
            base.GenerateId();
            Console.WriteLine(" ");

        }
    }
}
