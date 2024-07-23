using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.DurationTime
{
    internal class Duration
    {
        //attributes [properity]
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        //constructor to intialize it in main
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
            Normalize();
        }

        //override constructor due to paramters of totalseconds
        public Duration(int TotalSeconds)
        {
            Hours = TotalSeconds / 3600;
            Minutes = (TotalSeconds % 3600) / 60;
            Seconds = TotalSeconds % 60;
            //Normalize();
        }

        //normalize time
        private void Normalize()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }

        //override system object memeber
        //override ToString() method
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        //override Equals() method
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds ;
        }

        //override GetHashCode() method
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds );
        }

        //overloading operators +
        public static Duration operator +(Duration right, Duration left)
        {
            return new Duration(right.Hours + left.Hours, right.Minutes + left.Minutes, right.Seconds + left.Seconds);
        }

        //overloading operators +
        public static Duration operator +(Duration D, int second)
        {
            return new Duration(D.Hours, D.Minutes, D.Seconds + second);
        }

        //overloading operators +
        public static Duration operator +(int second, Duration D)
        {
            return new Duration(D.Hours, D.Minutes, D.Seconds + second);
        }

        //overloading operators ++
        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes + 1, duration.Seconds);
        }

        //overloading operators --
        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes - 1, duration.Seconds);
        }

        //overloading operators -
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration(left.Hours - right.Hours, left.Minutes - right.Minutes, left.Seconds - right.Seconds);
        }

        //overloading operators >
        public static bool operator >(Duration left, Duration right)
        {

            if (left.Hours == right.Hours)
            {
                return left.Minutes > right.Minutes;
            }
            else if (left.Minutes == right.Minutes)
                return left.Minutes > right.Minutes;
            else
                return left.Seconds > right.Seconds;

            ////OR

            //if (left.Hours > right.Hours)
            //    return true;
            //else if (left.Hours == right.Hours)
            //{
            //    if (left.Minutes > right.Minutes)
            //        return true;
            //    else if (left.Minutes == right.Minutes)
            //    {
            //        if (left.Seconds > right.Seconds)
            //            return true;
            //    }
            //}
            //return false;

            ////OR

            //// Compare based on Hours first
            //if (left.Hours > right.Hours)
            //{
            //    return true;
            //}
            //else if (left.Hours < right.Hours)
            //{
            //    return false;
            //}

            //// Compare based on Minutes if Hours are equal
            //if (left.Minutes > right.Minutes)
            //{
            //    return true;
            //}
            //else if (left.Minutes < right.Minutes)
            //{
            //    return false;
            //}

            //// Compare based on Seconds if Minutes are equal
            //return left.Seconds > right.Seconds;
        }

        //overloading operators <
        public static bool operator <(Duration left, Duration right)
        {

            if (left.Hours < right.Hours)
                return true;
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes < right.Minutes)
                    return true;
                else if (left.Minutes == right.Minutes)
                {
                    if (left.Seconds < right.Seconds)
                        return true;
                }
            }
            return false;

            ////OR

            //// Compare based on Hours first
            //if (left.Hours < right.Hours)
            //{
            //    return true;
            //}
            //else if (left.Hours > right.Hours)
            //{
            //    return false;
            //}

            //// Compare based on Minutes if Hours are equal
            //if (left.Minutes < right.Minutes)
            //{
            //    return true;
            //}
            //else if (left.Minutes > right.Minutes)
            //{
            //    return false;
            //}

            //// Compare based on Seconds if Minutes are equal
            //return left.Seconds < right.Seconds;
        }

        //overloading operators >=
        public static bool operator <=(Duration left, Duration right)
        {
            return left < right || left == right; 
        }

        //overloading operators >=
        public static bool operator >=(Duration left, Duration right)
        {
            return left > right || left == right;
        }

        //overloading operators true
        public static bool operator true(Duration duration)
        {
            return duration.Hours != 0 || duration.Minutes != 0 || duration.Seconds != 0;
        }

        //overloading operators false
        public static bool operator false(Duration duration)
        {
            return duration.Hours == 0 || duration.Minutes == 0 || duration.Seconds == 0;
        }

        //overloading operators true
        public static explicit operator DateTime(Duration duration)
        {
            //return new DateTime(22,05,2024,duration.Hours,duration.Minutes, duration.Seconds);
            return new DateTime().AddHours(duration.Hours).AddMinutes(duration.Minutes).AddSeconds(duration.Seconds);
        }
    }
}
