using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class SendTextEmail : ISendEmail
    {
        public void Send(string email, int password, string subject)
        {
            Console.WriteLine($"Sending SMS to {email} with password: {password} and subject {subject}");
        }
        public void SendEmail(string email)
        {
            Send(email, 1234, "This is a Text Email");
        }
    }
}
