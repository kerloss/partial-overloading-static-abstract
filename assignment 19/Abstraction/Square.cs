using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Abstraction
{
    internal class Square : RectBase
    {
        //constructor
        public Square(double dim)
        {
            dim01 = dim02 = dim;
        }

        public override double parameter 
        {
            get { return dim01 * dim02; }
        }

        //public override double CalArea()
        //{
        //    return dim01 * dim02;
        //}
    }
}
