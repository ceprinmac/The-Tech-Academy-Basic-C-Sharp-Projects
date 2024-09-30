using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Multiply input by 50  
        Console.Write("Enter a number to multiply by 50: ");
        int number1 = Int32.Parse(Console.ReadLine());
        int result1 = number1 * 50;
        Console.WriteLine($"Result: {result1}");

        // Task 2: Add 25 to the input  
        Console.Write("Enter a number to add 25: ");
        int number2 = Int32.Parse(Console.ReadLine());
        int result2 = number2 + 25;
        Console.WriteLine($"Result: {result2}");

        // Task 3: Divide input by 12.5  
        Console.Write("Enter a number to divide by 12.5: ");
        double number3 = Double.Parse(Console.ReadLine());
        double result3 = number3 / 12.5;
        Console.WriteLine($"Result: {result3}");

        // Task 4: Check if input is greater than 50  
        Console.Write("Enter a number to check if greater than 50: ");
        int number4 = Int32.Parse(Console.ReadLine());
        bool result4 = number4 > 50;
        Console.WriteLine($"Result: {result4}");

        // Task 5: Remainder when divided by 7  
        Console.Write("Enter a number to find the remainder when divided by 7: ");
        double number5 = Double.Parse(Console.ReadLine());
        double remainder = number5 % 7;
        Console.WriteLine($"Remainder: {remainder}");

    }
}
