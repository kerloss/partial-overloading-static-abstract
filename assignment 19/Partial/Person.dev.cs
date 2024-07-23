using assignment_19.Sealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Partial
{
    partial class Person : parent
    {
        public decimal Salary { get; set; }

        partial void Print()
        {
            Console.WriteLine("hello partial ");
        }
    }
}
