using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA <= 0 || sideB <= 0 || sideC <= 0) 
            {
                throw new ArgumentException("Side lengths must be positive.");
            }

            if(sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Triangle inequality is violated");
            }

            a = sideA;
            b = sideB;
            c = sideC;
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));   
        }
    }
}
