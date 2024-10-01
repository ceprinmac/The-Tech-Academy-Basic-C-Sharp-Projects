namespace MethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            try
            {
                // Ask the user for input  
                Console.WriteLine("Number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                // Call the Multiplication method and display the result  
                int resultMultiply = mathOperations.Multiplication(userInput);
                Console.WriteLine($"Result of multiplying by 2: {resultMultiply}");

                // Call the Addition method and display the result  
                int resultAdd = mathOperations.Addition(userInput);
                Console.WriteLine($"Result of adding 10: {resultAdd}");

                // Call the Subtraction method and display the result  
                int resultSubtract = mathOperations.Subtraction(userInput);
                Console.WriteLine($"Result of subtracting 5: {resultSubtract}");

            }
            catch (Exception ex)
            {
                // Print error message
                Console.WriteLine("Please enter a number to perform math operations on");
            }

        }

    }
}
