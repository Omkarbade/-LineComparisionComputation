using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class Program
    {
        //Main method /Entry Point of program
        static double distance1, distance2;
        public static void CheckLine()
        {
            LineComputation lc1 = new LineComputation(4.2, 3.2, 1.7, 2.1);
            distance1 = lc1.Length();
            LineComputation lc2 = new LineComputation(3.6, 4.4, 1.2, 2.4);
            distance2 = lc2.Length();
            Console.WriteLine(distance1);
            Console.WriteLine(distance2);
        }
        static void Main(string[] args)
        {
            //Showing message on console
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            Program.CheckLine();
            Console.ReadLine();
        }
    }
}
