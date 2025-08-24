using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Membership
    {
        private readonly IEmail _email;
        public Membership(IEmail email)
        {
            _email = email;
        }
      public void SignUp(string email, string password)
        {
            _email.SendWelcomeEmail(email);
        }

    }
}
