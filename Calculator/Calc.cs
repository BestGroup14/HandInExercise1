using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double Accumulator
        {
            get; private set;
        }

        public double Add1(double addend)
        {
            Accumulator = Accumulator + addend;

            return Accumulator;
        }

        public double Subtract1(double subtractor)
        {
            Accumulator = Accumulator - subtractor;

            return Accumulator;
        }

        public double Multiply1(double multiplier)
        {
            Accumulator = Accumulator * multiplier;

            return Accumulator;
        }

        public double Power1(double exponent)
        {
            if (exponent > 0)
            {
                Accumulator = Math.Pow(Accumulator, exponent);
            }
            else if (exponent < 0)
            {
                Accumulator = (1 / Math.Pow(Accumulator, -exponent));
            }
            else if(exponent == 0)
            {
                Accumulator = 1;
            }

            return Accumulator;
        }

        public double Divide1(double divisor)
        {
            try
            {
                Convert.ToDecimal(Accumulator = Accumulator / divisor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return Accumulator;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;

            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;

            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;

            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);

            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                Accumulator = dividend / divisor;
                return Accumulator;
            }
            else
            {
                return 0;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
