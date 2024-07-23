using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Abstraction
{
    //Abstract class : partial implementation for other classes
    //you can not create object from abstract class
    //bec abstract is not fully implemented
    internal abstract class Shape
    {
        //abstract property : not fully implemented
        public double dim01 { get; set; }
        public double dim02 { get; set; }

        public abstract double parameter
        {
            get; 
        }   //abstract property
        public abstract double CalArea(); //partial implementation //abstract method
    }
}
