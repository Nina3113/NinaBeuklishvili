
int[] array = { 435, 657, 432, 958, 767 };
int index = 0;

int digitsSum = DigitsSumAtIndex(array, index);
Console.WriteLine($"Sum of digits at index {index} is {digitsSum}");

static int DigitsSumAtIndex(int[] array, int index)
{
    if (index < 0 || index >= array.Length)
    {
        throw new ArgumentOutOfRangeException("The index is out of range");
    }
    int number = array[index];
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}