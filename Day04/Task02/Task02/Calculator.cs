using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a , int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if(b != 0)
            {
                return a / b;
            }else
            {
                throw new DivideByZeroException("Can not be divided by zero");            }
        }
    }
}
