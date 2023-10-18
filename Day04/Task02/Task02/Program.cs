// See https://aka.ms/new-console-template for more information
using Task02;


int resultAdd = Calculator.Add(20, 30);
int resultSubtract = Calculator.Subtract(20, 30);
int resultMultiply = Calculator.Multiply(20, 30);

Console.WriteLine($"Result of addition: {resultAdd}");
Console.WriteLine($"Result of subtraction: {resultSubtract}");
Console.WriteLine($"Result of multiplication: {resultMultiply}");

try
{
    double resultDivide = Calculator.Divide(10, 0);
    Console.WriteLine($"Result of division {resultDivide}");

}catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message );
}
{

}