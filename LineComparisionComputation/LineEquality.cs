using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineEquality
    {
        //instance variable to store distance of given co-ordinates
        static double distance1, distance2;

        // Method for creating co-ordinates
        public static void CheckLine()
        {
            LineComputation lc1 = new LineComputation(4.2, 3.2, 1.7, 2.1);
            distance1 = lc1.Length();
            LineComputation lc2 = new LineComputation(3.6, 4.4, 1.2, 2.4);
            distance2 = lc2.Length();
            Console.WriteLine("Length of Line1: " + distance1);
            Console.WriteLine("Length of Line2: " + distance2);

            //checking equality of lines using equals method 
            if (distance1.CompareTo(distance2) > 0)
            {
                Console.WriteLine("line one is greater than line two");
            }
            else if (distance1.CompareTo(distance2) < 0)
            {
                Console.WriteLine("line one is less then line Two");
            }
            else if (distance1.CompareTo(distance2) == 0)
            {
                Console.WriteLine("Both Lines are Equals");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
