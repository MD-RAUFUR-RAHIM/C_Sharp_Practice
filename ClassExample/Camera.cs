using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Camera : Product
    {
       public Camera() : base(string.Empty, 0)
        { 
            id = 0;
        }
        public override string GetUrlFriendName()
        {
            return name.Replace(' ', '+');
        }
    }
}
