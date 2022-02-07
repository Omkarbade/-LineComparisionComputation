using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineComputation
    {
        /// <summary>
        /// Using oops concept 
        /// </summary>
        /// 
        //Instance Variables
        double pointX1, pointY1, pointX2, pointY2;

        //static variables
        static double distance1, distance2;

        //Constructor initilalizing values through pass by reference
        public LineComputation(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            this.pointX1 = pointX1;
            this.pointY1 = pointY1;
            this.pointX2 = pointX2;
            this.pointY2 = pointY2;
        }
        // Method to get length of 2 lines
        public static void LengthofLines()
        {
            LineComputation d1 = new LineComputation(4.7, 3.4, 1.5, 2.5);
            distance1 = d1.Length();
            LineComputation d2 = new LineComputation(3.1, 4.5, 2.4, 4.2);
            distance2 = d2.Length();
            Console.WriteLine("Length of Line1: " + distance1);
            Console.WriteLine("Length of Line2: " + distance2);
            Equals(distance1, distance2);
            CompareTo(distance1, distance2);
        }
        //Method to compute length of given co-ordinates of geometery
        public double Length()
        {
            //returning double type value after computation
            return Math.Sqrt((pointX2 - pointX1) * (pointX2 - pointX1) + (pointY2 - pointY1) * (pointY2 - pointY1));
        }

        //method to check Equality of two lines using Equals function
        public static void Equals(double d1, double d2)
        {
            if (d1.Equals(d2))
                Console.WriteLine("Line1 and Line2 are Equal");
            else
                Console.WriteLine("Both lines are not Equal");
        }

        //method to Compare two lines using CompareTo function
        public static void CompareTo(double d1, double d2)
        {
            if (d1.CompareTo(d2) > 0)
                Console.WriteLine("Line1 is greater than Line2");
            if (d1.CompareTo(d2) < 0)
                Console.WriteLine("Line2 is greater than Line1");
            if (d1.CompareTo(d2) == 0)
                Console.WriteLine("Line1 and Line2 are Equal");
        }
    }
}
