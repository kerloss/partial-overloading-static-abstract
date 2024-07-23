using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(double raduis)
        {
            dim01 = dim02 = raduis;
        }

        public override double parameter
        {
            get { return 2 * Math.PI * dim01; }
        }

        public override double CalArea()
        {
            return Math.PI * Math.Pow(dim01, 2);
        }
    }
}
