using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Triangle
    {   public double SideLength { get; set; }
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle (double sideLength)
        {
            if(sideLength < 0)
            {
                throw new ArgumentException("Invalid side length for an equilateral triangle.");
            }
            SideLength = sideLength;
        }

        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Invalid sides.");
            }
            if(a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Triangle inequality is violated.");
            }

            sideA = a;
            sideB = b;
            sideC = c;
        }

        public double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            if(t1 is null && t2 is null)
            {
                return true;
            }
            if(t1 is null || t2 is null)
            {
                return false;
            }
            return t1.sideA == t2.sideA && t1.sideB == t2.sideB && t1.sideC == t2.sideC;
            
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return t1.sideA != t2.sideA || t1.sideB != t2.sideB || t1.sideC != t2.sideC;
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            if(t1 is null)
            {
                return false;
            }
            if(t2 is null)
            {
                return true;
            }
            return t1.GetArea() > t2.GetArea();
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            return t1.GetArea() < t2.GetArea();
        }

        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            if(t1 is null || t2 is null)
            {
                throw new ArgumentNullException();
            }

            double combinedArea = t1.GetArea() + t2.GetArea();

            //The sides of the resulting right triangle
            double sideA = Math.Sqrt(combinedArea);
            double sideB = 2 * combinedArea / sideA;
            double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);

            return new Triangle(sideA, sideB, sideC); 
        }

        public override string ToString()
        {
            return $"Equilateral triangle with side length: {SideLength}";
        }

        public static explicit operator Triangle(double side)
        {
            if(side <= 0)
            {
                throw new ArgumentException("Invalid side length.");
            }
            return new Triangle(side);
        }

    }
}
