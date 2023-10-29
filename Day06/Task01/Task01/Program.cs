
using Task01;

 static Triangle GetTriangle() {
    double sideA, sideB, sideC;

    Console.WriteLine("Enter the lengths of triangle sides: ");

    Console.Write("Side A: ");
    if (!double.TryParse(Console.ReadLine(), out sideA))
    {
        throw new ArgumentException("Invalid side length for side A.");
    }

    Console.Write("Side B: ");
    if (!double.TryParse(Console.ReadLine(), out sideB))
    {
        throw new ArgumentException("Invalid side length for side B.");
    }

    Console.Write("Side C: ");
    if (!double.TryParse(Console.ReadLine(), out sideC))
    {
        throw new ArgumentException("Invalid side length for side C.");
    }
    return new Triangle(sideA, sideB, sideC);
}

Triangle triangle1 = GetTriangle();
Triangle triangle2 = GetTriangle();

Console.WriteLine($"Equality: {triangle1 == triangle2}");
Console.WriteLine($"Inequality: {triangle1 != triangle2}");

Console.WriteLine($"First triangle is greater than second one (based on area): {triangle1 > triangle2}");
Console.WriteLine($"First triangle is less than second one (based on area): {triangle1 < triangle2}");

Triangle combinedTriangle = triangle1 + triangle2;
Console.WriteLine($"New triangle area: {combinedTriangle.GetArea()}");

double sideLength = 3.0;
Triangle equilateralTriangle = (Triangle)sideLength;
Console.WriteLine(equilateralTriangle);
