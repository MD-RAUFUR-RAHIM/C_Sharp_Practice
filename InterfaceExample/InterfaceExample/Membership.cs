using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Membership
    {
        private readonly ISendEmail _emailSender;

        public Membership(ISendEmail emailSender)
        {
            _emailSender = emailSender;
        }

        public void SignUP(string username)
        {
            _emailSender.SendEmail(username);
        }

    }
}
