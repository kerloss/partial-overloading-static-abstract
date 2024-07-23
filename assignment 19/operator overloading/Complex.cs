using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.operator_overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"Real : {Real}, Imag : {Imag}";
        }

        //Function must be non private and static [class member method]
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }

        public static Complex operator ++(Complex complex)
        {
            return new Complex
            {
                Real = (complex?.Real ?? 0) + 1,
                Imag = (complex?.Imag ?? 0)
            };
        }

        public static Complex operator --(Complex complex)
        {
            return new Complex
            {
                Real = (complex?.Real ?? 0) - 1,
                Imag = (complex?.Imag ?? 0)
            };
        }

        public static bool operator >(Complex left, Complex right)
        {
            //return ((left?.Real == right?.Real && left?.Imag > right?.Imag) || left?.Real > right?.Real);
            if (left?.Real == right?.Real)
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            return ((left?.Real == right?.Real && left?.Imag < right?.Imag) || left?.Real < right?.Real);

            //if (left?.Real == right?.Real)
            //    return left?.Imag < right?.Imag;
            //else
            //    return left?.Real < right?.Real;
        }

        public static /*int*/ explicit operator int(Complex complex)
        {
            return complex?.Real ?? 0;
        }

        public static /*string*/ implicit operator string(Complex complex)
        {
            return complex?.ToString() ?? string.Empty;
        }
    }
}
