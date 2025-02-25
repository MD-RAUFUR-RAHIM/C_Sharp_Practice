using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class SendHtmlEmail : ISendEmail
    {
        public void HtmlEmail(string email, int serialNo, int subject) 
        {
            Console.WriteLine("Sending email to " + email+ " with serial No: " + serialNo + " and subject " + subject);
        }
        public void SendEmail(string email)
        {
            HtmlEmail(email, 101, 45);
        }
    }
}
