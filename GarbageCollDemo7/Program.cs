using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollDemo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();             //commented out on page 330.
            //Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            using (Calculator calculator = new Calculator())            //added on page 330.
            {
                //Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");   //commented out on page 333.
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");        //added out on page 333.
            }
            Console.WriteLine("Program finishing");
        }
    }
}
