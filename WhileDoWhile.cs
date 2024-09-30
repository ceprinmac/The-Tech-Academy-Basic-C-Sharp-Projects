namespace WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement  
            Console.WriteLine("While Statement:");
            bool condition = false;
            int counter = 0;

            while (!condition && counter < 6)
            {
                Console.WriteLine($"Counter is: {counter}");
                counter++;
                if (counter == 5)
                {
                    condition = true;  // Change condition to true to exit loop  
                }
            }

            // Boolean comparison using a do while statement  
            Console.WriteLine("\nDo While Statement:");
            condition = false;
            counter = 0;

            do
            {
                Console.WriteLine($"Counter is: {counter}");
                counter++;
                if (counter == 5)
                {
                    condition = true;  // Change condition to true to eventually end loop  
                }
            } while (!condition);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
