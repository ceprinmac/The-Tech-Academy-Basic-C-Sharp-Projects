namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {10, 20, 30, 40 ,50 };

            try
            {
                // Ask for user input to be the devidend
                Console.WriteLine("Divide by: ");
                int dividend = Convert.ToInt32(Console.ReadLine());

                // Loop through list and divide each item by the user input
                foreach (int divisor in list)
                {
                    int answer = divisor / dividend;
                    Console.WriteLine(divisor + " divided by " + dividend + " is equal to " + answer);
                }
                Console.WriteLine("Entered try block."); // print a message to the display to let you know the program has emerged from the try/catch block
            }
            catch (Exception ex) 
            { 
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Entered catch block."); // print a message to the display to let you know the program has emerged from the try/catch block
            }

            Console.WriteLine("Exited try/catch block."); // print a message outside try/catch block.
            Console.ReadLine();
        }
    }
}
