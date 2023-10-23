using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double cRadius) 
        {
            if(cRadius <= 0)
            {
                throw new ArgumentException("Radius must be positive");
            }

            radius = cRadius;
        }

        public override double Perimeter()
        {
            return  2 * Math.PI * radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
