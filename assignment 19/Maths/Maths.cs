using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Maths
{
    public static class Maths
    {
        //Add method
        public static int Add(int x, int y) { return x + y; }

        //Subtract method
        public static int Subtract(int x, int y) { return x - y; }

        //Mulitply method
        public static int Multiply(int x, int y) { return x * y; }

        //Divided method
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Can't divided by zero");
            }
            return x / y;
        }
    }
}
