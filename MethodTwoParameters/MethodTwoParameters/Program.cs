namespace MethodTwoParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(Optional) Enter second number (press enter to skip): ");
            string secondInput = Console.ReadLine();

            int b;

            // Check if the user provided a second number  
            if (string.IsNullOrEmpty(secondInput))
            {
                // If no input, default to zero  
                b = 0;
            }
            else
            {
                // Otherwise, parse the input to an integer  
                b = int.Parse(secondInput);
            }

            int res = mathOperations.Subtraction(a, b);

            Console.WriteLine("The difference is {0}", res);
        }
    }
}
