using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class TextEmail : IEmail
    {
        public void SendEmail(string email,string subject, string body)
        {

        }


        public void SendWelcomeEmail(string email)
        {
            SendEmail(email, "This is Text Email", "This is body");
        }
    }
}
