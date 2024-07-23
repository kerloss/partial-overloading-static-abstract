using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Abstraction
{
    internal abstract class RectBase : Shape
    {
        //public override double parameter => throw new NotImplementedException();

        public override double CalArea()
        {
            return dim01 * dim02;
        }
    }
}
