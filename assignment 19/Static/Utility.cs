using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Static
{
    //static class  : container for static members 
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //1. static atrribute
        //comipiler will initialize static attribute with default value = 0

        //private static double pi /*= 3.14*/;
        //class memeber property
        //1. static attribute
        //2. constant

        //2. constant
        private const double pi = 3.14;
        public static double PI
        {
            get { return pi; } //read only
            //set { pi = value; }
        }

        //object memeber constructor
        //public Utility(int _x, int _y)
        //{
        //    X = _x;
        //    Y = _y;
        //    //PI = 3.14; //not best way
        //}

        //public override string ToString()
        //{
        //    return $"X : {X}, Y : {Y}";
        //}

        //class memeber method [static]
        //the result od calling method "cmtoInch" will not differ by the diffrent of object state [data(x,y)]
        //helper method

        ////static constructor
        ////has no access modifier
        ////has no paramaters
        //static Utility()
        //{
        //    //intialize for static constructor
        //    //max for each class have one static constructor
        //    //CLR will call static constructor with first usage of class
        //    //class usage :
        //        ///1. create object from class
        //        ///2. create object from class inherit this class
        //        ///3. call static method
        //        ///4. call static property
        //    PI = 3.14;
        //}

        public static double CmToInch (double cm)
        {
            return cm / 2.54;
        }

        //class memeber method [static]
        public static double CalCircleArea (double raduis)
        {
            return PI * Math.Pow(raduis, 2);
        }
    }
}
