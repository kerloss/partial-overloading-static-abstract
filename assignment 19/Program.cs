using assignment_19.Abstraction;
using assignment_19.Casting_overloading;
using assignment_19.DurationTime;
using assignment_19.operator_overloading;
using assignment_19.Partial;
using assignment_19.Sealed;
using assignment_19.Static;

namespace assignment_19
{
    internal class Program
    {
        public static void Print(PaymentProcessor payment, double amount)
        {
            payment.ProcessPayment(amount);
        }

        static void Main(string[] args)
        {
            #region Demo

            #region Operator overloading
            Complex c1 = new Complex() { Real = 3, Imag = 4 };
            Complex c2 = new Complex() { Real = 1, Imag = 2 };

            #region Binary Operators
            //Complex c3 = c1 + c2;

            //c3 += c1;
            ////c3 = c3 + c1;
            //c3 = c1 - c2; 
            #endregion

            //Complex c3 = c2;

            #region Uniray operator
            //Console.WriteLine(c1.GetHashCode()); //54267293
            //Console.WriteLine(c3.GetHashCode()); //18643596

            //Console.WriteLine(c1); //Real : 3, Imag : 4
            //Console.WriteLine(c3); //Real : 1, Imag : 2

            ////c3 = c1++;
            ////Console.WriteLine("After postfix c1++");
            ////Console.WriteLine(c1.GetHashCode()); //33574638
            ////Console.WriteLine(c3.GetHashCode()); //54267293
            ////Console.WriteLine(c1); //Real : 4, Imag : 4
            ////Console.WriteLine(c3); //Real : 3, Imag : 4

            //c3 = ++c1;
            //Console.WriteLine("After prefix ++c1");
            //Console.WriteLine(c1.GetHashCode()); //33736294
            //Console.WriteLine(c3.GetHashCode()); //33736294
            //Console.WriteLine(c1); //Real : 5, Imag : 4
            //Console.WriteLine(c3); //Real : 5, Imag : 4 
            #endregion

            #region Comparison operator [relational operator]
            //if (c1 > c2)
            //    Console.WriteLine("C1 is greater ");
            //else if (c1 < c2)
            //    Console.WriteLine("C2 is greater ");
            //else
            //    Console.WriteLine("Both Equal "); 
            #endregion

            #endregion

            #region Casting operator from value type => value type
            //long x = 50;
            //int y = (int)x; //(int)casting operator

            //int z = (int)c1;
            //Console.WriteLine(z);

            //string str = (string)c1; //Explicit
            //str = c1; //implicit
            //Console.WriteLine(str); 
            #endregion

            #region Need of casting overloading ref type => ref type
            //Employee employee = new Employee()
            //{
            //    Id = 10,
            //    FullName = "Maha Ahmed",
            //    Email = "maha@gmail.com",
            //    Password = "password"
            //};

            ////casting overloading from ref to ref
            //EmployeeViewModel employeeViewModel = (EmployeeViewModel)employee;
            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName);
            //Console.WriteLine(employeeViewModel.Email);
            #endregion

            #region Abstraction
            //Shape shape = new Shape();
            //shape.CalArea();

            //Rectangle rectangle = new Rectangle() { dim01 = 10, dim02 = 20 };
            //Console.WriteLine(rectangle.CalArea());
            //Console.WriteLine(rectangle.parameter);

            //Circle circle = new Circle(10);
            //Console.WriteLine( circle.CalArea());
            //Console.WriteLine(circle.parameter);
            #endregion

            #region Static and const
            //Utility obj01 = new Utility(1, 2);
            //Utility obj02 = new Utility(2, 3);

            ////object memeber method
            //Console.WriteLine(obj01.CmToInch(10));  //3.93
            //Console.WriteLine(obj02.CmToInch(10));  //3.93

            ////class memeber method
            //Console.WriteLine(Utility.CmToInch(10));

            //Console.WriteLine("**********************");
            ////object memeber method
            //Console.WriteLine(obj01.CalCircleArea(10)); //314
            //Console.WriteLine(obj02.CalCircleArea(10)); //314

            ////class member method
            //Console.WriteLine(Utility.CalCircleArea(10)); //314
            //Console.WriteLine(Utility.PI); //3.14

            //Console.WriteLine(Guid.NewGuid()); 
            #endregion

            #region Sealed
            //PaymentProcessor payment = new PaymentProcessor();
            //payment.ProcessPayment(10); //10*10=100

            //InheritPayment payment1 = new InheritPayment();
            //payment1.ProcessPayment(10); //10*20=200 
            #endregion

            #region Partial class
            //Person person = new Person()
            //{
            //    Id = 1,
            //    Name = "test",
            //    Age = 20,
            //    Salary = 1000
            //}; 
            #endregion

            #endregion

            #region first project

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());

            ////read from the users 2 points p1 &p2
            //Point3D p1 = ReadPointFromUser("Enter coordinates for Point 1(X, Y, Z):");
            //Point3D p2 = ReadPointFromUser("Enter coordinates for Point 2(X, Y, Z):");

            ////try p1 == p2
            //if (p1 == p2)
            //{
            //    Console.WriteLine("The 2 points are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("The 2 points aren't Equal");
            //}

            ////Define array of points
            //Point3D[] points = new Point3D[]
            //{
            //    new Point3D(4,5,9),
            //    new Point3D (1,2,3),
            //    new Point3D(4,8,9)
            //};

            //// Sort the array based on X and Y coordinates
            //Array.Sort(points);

            //// Print the sorted array
            //Console.WriteLine("Sorted Points:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            ////clone a point
            //Point3D clonePoint = (Point3D)p1.Clone(); //deep copy
            //Console.WriteLine($"cloned points : {clonePoint}");

            ////function to read 2 points of users
            //static Point3D ReadPointFromUser(string points)
            //{
            //    int x, y, z;
            //    while (true)
            //    {
            //        Console.WriteLine(points);
            //        Console.Write("Enter X coordinate: ");
            //        if (int.TryParse(Console.ReadLine(), out x))
            //            break;
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }

            //    while (true)
            //    {
            //        Console.Write("Enter Y coordinate: ");
            //        if (int.TryParse(Console.ReadLine(), out y))
            //            break;
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }

            //    while (true)
            //    {
            //        Console.Write("Enter Z coordinate: ");
            //        if (int.TryParse(Console.ReadLine(), out z))
            //            break;
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }
            //    return new Point3D(x, y, z);
            //}

            #endregion

            #region second project
            //Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes
            //two parameters.Call each method in Main().Modify the program so that you do not have to create an
            //instance of class to call the four methods.

            //int num1 = 10;
            //int num2 = 20;

            ////call add method
            //int sum = Maths.Maths.Add(num1, num2);
            //Console.WriteLine($"Add : {num1} + {num2} = {sum}");

            //int diff = Maths.Maths.Subtract(num1, num2);
            //Console.WriteLine($"Diffrence : {num1} - {num2} = {diff}");

            //int product = Maths.Maths.Multiply(num1, num2);
            //Console.WriteLine($"multiplay : {num1} * {num2} = {product}");

            //double div = Maths.Maths.Divide(num1, num2);
            //Console.WriteLine($"Divided : {num1} / {num2} = {div}");
            #endregion

            #region third project
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString()); //1 Hours, 10 Minutes, 15 Seconds

            Duration D1 = new Duration(3600);
            Console.WriteLine(D1.ToString()); //1 Hours, 0 Minutes, 0 Seconds

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString()); //2 Hours, 10 Minutes, 0 Seconds

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString()); //0 Hours, 11 Minutes, 6 Seconds

            //operator overloading
            Duration D4 = D1 + D2;
            Console.WriteLine($"D1 + D2 = {D4}"); //3 Hours, 10 Minutes, 0 Seconds

            Duration D5 = D1 + 7800;
            Console.WriteLine($"D1 + 7800 = {D5}"); //3 Hours, 10 Minutes, 0 Seconds

            Duration D6 = 666 + D3;
            Console.WriteLine($"666 + D3 = {D6}"); //0 Hours, 22 Minutes, 12 Seconds

            Duration D7 = ++D1;
            Console.WriteLine($"++D1 = {D7}"); //1 Hours, 1 Minutes, 0 Seconds

            Duration D8 = --D2;
            Console.WriteLine($"--D2 = {D8}"); //2 Hours, 9 Minutes, 0 Seconds

            Duration D9 = D1 - D2;
            Console.WriteLine($"D1 - D2 = {D9}"); //-1 Hours, -8 Minutes, 0 Seconds

            if (D1 > D2)
                Console.WriteLine("D1 i greater than D2");
            else
                Console.WriteLine("D2 is greater that D1");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal D2");
            else
                Console.WriteLine("D2 is less than or equal D1");

            if (D1)
                Console.WriteLine("D1 is true");
            else
                Console.WriteLine("D1 is false");

            DateTime dateTime = (DateTime)D1;
            Console.WriteLine($"DateTime = {dateTime}");
            #endregion

        }
    }
}
