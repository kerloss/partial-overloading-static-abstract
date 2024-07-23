using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.operator_overloading
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        //3D point properity
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //constructor chaining
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        //overide toString
        public override string ToString()
        {
            return $"Point Coordinates: {X} , {Y} , {Z}";
        }

        public int CompareTo(Point3D? obj)
        {
            if (X != obj?.X)
                return X.CompareTo(obj?.X);
            if (Y != obj?.Y)
                return Y.CompareTo(obj?.Y);

            return Z.CompareTo(obj?.Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        //overloading == operators
        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left?.X != right?.X)
                return left?.X == right?.X;
            else if (left?.Y != right?.Y)
                return left?.Y == right?.Y;
            else
            return (left?.X == right?.X) && (left?.Y == right?.Y) && (left?.Z == right?.Z);
        }

        //overloading != operators
        public static bool operator !=(Point3D left, Point3D right)
        {
            if (left?.X != right?.X)
                return left?.X != right?.X;
            else if (left?.Y != right?.Y)
                return left?.Y != right?.Y;
            else if (left?.Z != right?.Z)
                return left?.Z != right?.Z;
            return (left?.X != right?.X) && (left?.Y != right?.Y) && (left? .Z != right?.Z);

            //OR
            //return !(left == right);
        }
    }
}
