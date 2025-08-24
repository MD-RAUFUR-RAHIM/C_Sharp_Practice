using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static string ToShortString(this string orginalText, int length)
        {
           if(length > orginalText.Length)
            {
                return orginalText;
            }
            else
            {
                return orginalText.Substring(0, length) + "...";
            }
        }
    }
}
