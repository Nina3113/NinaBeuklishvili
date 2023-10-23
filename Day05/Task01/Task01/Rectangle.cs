using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Rectangle : Shape
    {
        double sideA, sideB;

        public Rectangle(double firstSide, double secondSide)
        {
            if(firstSide <= 0 || secondSide <= 0)
            {
                throw new ArgumentException("Side must be positive");
            }

            sideA = firstSide;
            sideB = secondSide;
        }

        public override double Perimeter()
        {
            return (sideA + sideB) * 2;
        }

        public override double Area()
        {
            return sideA * sideB;
        }
    }
}
