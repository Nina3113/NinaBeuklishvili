
Console.Write("Enter the size of the array (N): ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out int element))
        {
            arr[i] = element;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid natural number.");
            i--;
        }
    }

    // Sort the array 
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    Console.WriteLine("\nSorted array in ascending order:");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}
else
{
    Console.WriteLine("Invalid input for array size. Please enter a positive integer.");
}
