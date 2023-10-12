﻿

char[] array = GetCharArray();
char symbol = 'a';
int symbolNum = SymbolCount(array, symbol);
PrintResult(symbol, symbolNum);

//Get a char array from the user
char[] GetCharArray()
{
    Console.WriteLine("Enter the size of an array: ");

    if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
    {
        char[] array = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter a char at index {i}: ");
            if (char.TryParse(Console.ReadLine(), out char symbol))
            {
                array[i] = symbol;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one character");
                i--;
            }
        }
        return array;
    }
    else
    {
        Console.WriteLine("Invalid size input. Please enter a positive integer.");
        return null;
    }
}

int SymbolCount(char[] array, char c)
{
    int count = 0;
    foreach (char ch in array)
    {
        if (array != null)
        {
            if (ch == c) count++;
        }
    }
    return count;
}

void PrintResult(char ch, int num)
{
    Console.WriteLine($"Symbol \"{ch}\" was used {num} times");
}



