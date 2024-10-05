using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            // Convert inputs to integers
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            // Perform division
            int result = Divide(number1, number2);

            // Print the result if no exceptions occur
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException)
        {
            // Caught when input is not a valid integer
            Console.WriteLine("Error: One or both of the inputs are not valid integers. Please enter valid numbers.");
        }
        catch (DivideByZeroException)
        {
            // Caught when attempting to divide by zero
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            // Caught when the input number is too large or too small
            Console.WriteLine("Error: The input number is too large or too small.");
        }
        catch (Exception)
        {
            // Catches any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    // Method to perform division
    static int Divide(int a, int b)
    {
        return a / b;
    }
}

