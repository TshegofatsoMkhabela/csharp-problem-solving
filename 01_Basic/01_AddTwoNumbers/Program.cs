using System;

class Program
{
    static void Main()
    {
        double number1, number2;    // Input
        double sum;                 // Output

        // Get two valid numbers from the user
        number1 = getValidNumber("Enter the first number: ");
        number2 = getValidNumber("Enter the second number: ");

        sum = number1 + number2;

        // Display the result
        Console.WriteLine($"The sum of your numbers is {sum}");
    }

    static double getValidNumber(string userPrompt)
    {
        double validNumber;

        // Prompt the user until they enter a valid number
        Console.Write(userPrompt);
        while (!double.TryParse(Console.ReadLine(), out validNumber))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        return validNumber;
    }
}