namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for the applicant's age 
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the applicant has ever had a DUI  
            Console.WriteLine("Have you ever had a DUI?");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask for the number of speeding tickets  
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Evaluate the qualification criteria  
            bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

            // Print the result  
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
        }
    }
}
