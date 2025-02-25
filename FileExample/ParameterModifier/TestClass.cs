using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    public class TestClass
    {
        public void Method1(ref int count)
        {
            count = 7;
        }
        public void Method2(int count)
        {

        }
        public void Method3(out int count)
        {
            throw new NotImplementedException();
        }
    }
}
