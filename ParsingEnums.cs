using System;

namespace ParsingEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");

            // Read user input  
            string userInput = Console.ReadLine();

            try
            {
                // Parse the input to the DaysOfWeek enum  
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException)
            {
                // Handle the exception if the input is not a valid day  
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Wait for user to press a key before closing  
            Console.ReadKey();
        }

        // Define the enum for the days of the week  
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
