using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISendEmail email = new SendTextEmail();
            Membership membership = new Membership(email);
            membership.SignUP("fsrtert");
            ISendEmail email2 = new SendHtmlEmail();
            Membership membership2 = new Membership(email2);
            membership2.SignUP("html@gmail.com");
        }
    }
}
