using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Abstraction
{
    //concrete class : fully implemented class
    internal class Rectangle : RectBase    //implement and inherit 
    {
        public override double parameter 
        {
            get { return (dim01 + dim02) * 2; }
        }

        //concrete class : concrete class [inherit]
        //class : interface [implement]
        //concrete class : abstract class [inherit & implement]
        //public override double CalArea()
        //{
        //    return dim01 * dim02;
        //}
    }
}
