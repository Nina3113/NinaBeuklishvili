

Console.Write("Enter the size of the matrix (2 or 3): ");
if (int.TryParse(Console.ReadLine(), out int size) && (size == 2 || size == 3))
{
    int[,] matrix = new int[size, size];

    Console.WriteLine("Enter the matrix elements row by row:");

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write($"Enter element at row {row + 1}, column {col + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int element))
            {
                matrix[row, col] = element;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                col--;
            }
        }
    }

    // Calculate determinant
    int determinant = CalculateDeterminant(matrix);

    // Print the matrix
    Console.WriteLine("\nEntered matrix:");
    PrintMatrix(matrix);

    // Print the determinant
    Console.WriteLine("\nDeterminant of the matrix: " + determinant);
}
else
{
    Console.WriteLine("Invalid input for matrix size. Please enter 2 or 3.");
}


// Calculate determinant of a 2x2 or 3x3 matrix
static int CalculateDeterminant(int[,] matrix)
{
    if (matrix.GetLength(0) == 2)
    {
        // For a 2x2 matrix: ad - bc
        int a = matrix[0, 0];
        int b = matrix[0, 1];
        int c = matrix[1, 0];
        int d = matrix[1, 1];
        return (a * d) - (b * c);
    }
    else if (matrix.GetLength(0) == 3)
    {
        // For a 3x3 matrix using the formula
        int a = matrix[0, 0];
        int b = matrix[0, 1];
        int c = matrix[0, 2];
        int d = matrix[1, 0];
        int e = matrix[1, 1];
        int f = matrix[1, 2];
        int g = matrix[2, 0];
        int h = matrix[2, 1];
        int i = matrix[2, 2];
        return (a * e * i) + (b * f * g) + (c * d * h) - (c * e * g) - (a * f * h) - (b * d * i);
    }
    else
    {
        throw new ArgumentException("Invalid matrix size for determinant calculation.");
    }
}

// Print the matrix
static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}


