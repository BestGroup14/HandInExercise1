using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calculator = new Calc();

            double test1 = calculator.Add(4, 4);
            double test2 = calculator.Subtract(10, 4);
            double test3 = calculator.Multiply(6, 7);
            double test4 = calculator.Power(2, 5);

            Console.WriteLine("Test 1: 8 = " + test1);
            Console.WriteLine("Test 2: 6 = " + test2);
            Console.WriteLine("Test 3: 42 = " + test3);
            Console.WriteLine("Test 4: 32 = " + test4);
            Console.ReadKey();
        }
    }
}
