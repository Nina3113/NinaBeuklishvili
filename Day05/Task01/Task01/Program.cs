
using Task01;

Console.WriteLine("Enter a figure number (1 - Triangle, 2 - Rectangle, 3 - Circle): ");
//Console.WriteLine("1 - Triangle");
//Console.WriteLine("2 - Rectangle");
//Console.WriteLine("3 - Circle");

int figure = int.Parse(Console.ReadLine());

switch(figure)
{
    case 1:
        Console.WriteLine("Enter side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side C: ");
        double sideC = double.Parse(Console.ReadLine());

        Shape triangle = new Triangle(sideA, sideB, sideC);
        Console.WriteLine($"Perimeter: {triangle.Perimeter()}");
        Console.WriteLine($"Area: {triangle.Area()}");
        break;

    case 2:
        Console.WriteLine("Enter side A: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B: ");
        double secondSide = double.Parse(Console.ReadLine());

        Shape rectangle = new Rectangle(firstSide, secondSide);
        Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");
        Console.WriteLine($"Area: {rectangle.Area()}");
        break;

    case 3:
        Console.WriteLine("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Shape circle = new Circle(radius);
        Console.WriteLine($"Perimeter: {circle.Perimeter()}");
        Console.WriteLine($"Area: {circle.Area()}");
        break;

    default:
        Console.WriteLine("Invalid figure number");
        break;
}