namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the method
            int result = mathOperations.Addition(2); // passing integer variable to Addition method
            int decimalResult = mathOperations.Addition(2.5); // passing double variable to Addition method
            int stringResult = mathOperations.Addition("5"); // passing string variable to Addition method

            Console.WriteLine("The sum of int variable: " + result); // displaying result for integer variable
            Console.WriteLine("The sum of decimal variable: " + decimalResult); // displaying result for double variable
            Console.WriteLine("The sum of string variable: " + stringResult); // displaying result for string variable


        }
    }
}
