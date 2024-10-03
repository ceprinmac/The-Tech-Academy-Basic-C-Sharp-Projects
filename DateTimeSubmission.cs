namespace DateTimeSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display current date time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime.ToString());

            // Ask user for number of hours
            Console.WriteLine("Enter number of hours: ");
            string userInput = Console.ReadLine();

            // Convert the user's input into an integer  
            int hoursToAdd;
            // Check if the input is a valid integer  
            if (int.TryParse(userInput, out hoursToAdd)) // Try to parse the input to an integer  
            {
                // Calculate the future date and time by adding the specified number of hours  
                DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd); // Add the hours to the current date and time  

                // Print the future date and time to the console  
                Console.WriteLine("The time in " + hoursToAdd + " hours will be: " + futureDateTime); // Output the future date and time  
            }
            else
            {
                // Inform the user that the input was invalid  
                Console.WriteLine("Invalid input. Please enter a valid number."); // Output an error message if the input is not a valid integer  
            }
        }
    }
}
