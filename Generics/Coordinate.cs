using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Coordinate<T,Q>
    {
        public T X {  get; set; }
        public Q Y { get; set; }
    }
}
