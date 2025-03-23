using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class PersonExtension
    {
        // this ar por je class thakbe oitake extend korlam
        public static string GetInfo(this Person person)
        {
            return "Id: " + person.Id + " Name: " + person.Name + "Address: " + person.Address;
        }
        
    }
}
