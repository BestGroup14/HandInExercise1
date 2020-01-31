using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        private double Accu;
        public double Accumulator
        {
            get { return Accu; }

            private set
            {
                if (Accu > 0)
                {
                    Accumulator = Accu;
                }
                else
                    Accumulator = 0;
            }
        }

        public double Add1(double addend)
        {
            Accu = Accu + addend;

            return Accu;
        }

        public double Subtract1(double subtractor)
        {
            Accu = Accu - subtractor;

            return Accu;
        }

        public double Multiply1(double multiplier)
        {
            Accu = Accu * multiplier;

            return Accu;
        }

        public double Power1(double exponent)
        {
            if (exponent > 0)
            {
                Accu = Math.Pow(Accu, exponent);
            }
            else if (exponent < 0)
            {
                Accu = (1 / Math.Pow(Accu, -exponent));
            }
            else if(exponent == 0)
            {
                Accu = 1;
            }

            return Accu;
        }

        public double Divide1(double divisor)
        {
            if (divisor != 0)
            {
                Accu = Accu / divisor;
                return Accu;
            }
            else
            {
                return 0;
            }
        }

        public double Add(double a, double b)
        {
            Accu = a + b;

            return Accu;
        }

        public double Subtract(double a, double b)
        {
            Accu = a - b;

            return Accu;
        }

        public double Multiply(double a, double b)
        {
            Accu = a * b;

            return Accu;
        }

        public double Power(double x, double exp)
        {
            Accu = Math.Pow(x, exp);

            return Accu;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                Accu = dividend / divisor;
                return Accu;
            }
            else
            {
                return 0;
            }
        }

        public void Clear()
        {
            Accu = 0;
        }

    }
}
