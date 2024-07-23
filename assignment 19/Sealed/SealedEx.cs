using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Sealed
{
    //sealed class
    sealed class PaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Amount = {amount * 10}");
        }
    }

    //class InheritPayment : PaymentProcessor
    //{
    //    public override void ProcessPayment(double amount)
    //    {
    //        Console.WriteLine($"Amount = {amount * 20}");
    //    }
    //}

    internal class parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("I am Parent");
        }
    }

    class Child : parent
    {
        //sealed method
        public sealed override void Print()
        {
            Console.WriteLine("I am Child");
        }

        //sealed property
        public sealed override int Salary 
        {
            get => base.Salary;
            set => base.Salary = value - 2000;
        }
    }

    //sealed class : class that can not inherit from
    sealed class GrandChild : Child
    {

    }

    //class Test : GrandChild
    //{
        
    //}
}
