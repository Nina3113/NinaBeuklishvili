
Random random = new Random();
int randomNumber = random.Next(1, 11);

int maxAttempts = 3;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("You have " + maxAttempts + " attempts to guess the number.");

for (int attempts = 1; attempts <= maxAttempts; attempts++)
{
    Console.Write("Attempt " + attempts + ": Enter a number between 1 and 10(included): ");

    if (int.TryParse(Console.ReadLine(), out int userNumber))
    {
        if (userNumber >= 1 && userNumber <= 10)
        {
            if (userNumber == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
                return;
            }
            else
            {
                Console.WriteLine("Sorry, that's not the correct number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

Console.WriteLine("Sorry, you didn't guess the number.");
