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
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            
            int result = Divide(number1, number2);

            
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid integers. Please enter valid numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The input number is too large or too small.");
        }
        catch (Exception)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}

