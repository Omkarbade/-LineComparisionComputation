using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Printing message on console
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            LineComputation.LengthofLines();  // calling static method of program class.
            Console.ReadLine();
        }
    }
}
