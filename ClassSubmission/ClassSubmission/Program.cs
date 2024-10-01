namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                // Call the Division method to output the result of input divided by 2 
                MathOperations.Division(input);

                // Call the overloaded method that uses an output parameter  
                int result;
                MathOperations.Division(input, out result);

                // Display the result using the output parameter  
                Console.WriteLine($"Using output parameter, the result is: {result}");

                // Additionally, demonstrate the overloaded double method  
                double decimalInput = Convert.ToDouble(input);
                MathOperations.Division(decimalInput);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }
    }
}
