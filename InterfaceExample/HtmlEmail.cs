using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class HtmlEmail: IEmail
    {
        public void Send(string email, string subject, string body)
        {

        }

        public void SendWelcomeEmail(string email)
        {
            Send(email, "This is Text Email", "This is body");
        }
    }
}
