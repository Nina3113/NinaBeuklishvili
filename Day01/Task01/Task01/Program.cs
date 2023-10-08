﻿

Console.Write("Enter the size of the first array (N1): ");
if (int.TryParse(Console.ReadLine(), out int n1) && n1 > 0)
{
    string[] firstArray = new string[n1];

    Console.WriteLine("Enter elements for the first array:");
    for (int i = 0; i < n1; i++)
    {
        Console.Write($"Element {i + 1}: ");
        firstArray[i] = Console.ReadLine();
    }


    Console.Write("\nEnter the size of the second array (N2): ");
    if (int.TryParse(Console.ReadLine(), out int n2) && n2 > 0)
    {
        string[] secondArray = new string[n2];

        Console.WriteLine("Enter elements for the second array:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Element {i + 1}: ");
            secondArray[i] = Console.ReadLine();
        }

        // Combine the arrays 
        string[] combinedArray = new string[n1 + n2];
        int combinedIndex = 0;

        for (int i = 0; i < Math.Max(n1, n2); i++)
        {
            if (i < n1)
            {
                combinedArray[combinedIndex] = firstArray[i];
                combinedIndex++;
            }
            if (i < n2)
            {
                combinedArray[combinedIndex] = secondArray[i];
                combinedIndex++;
            }
        }

        // Print the concatenated array
        Console.WriteLine("\nConcatenated array:");
        foreach (string item in combinedArray)
        {
            Console.Write(item + " ");
        }
    }
    else
    {
        Console.WriteLine("Invalid input for the size of the second array.");
    }
}
else
{
    Console.WriteLine("Invalid input for the size of the first array.");
}

