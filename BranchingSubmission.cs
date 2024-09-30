using System.Formats.Asn1;

namespace BranchingSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Ask for package weight
            Console.WriteLine("Package Weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50) {
                //Print error message and exit program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            else
            {
                //Ask for package width
                Console.WriteLine("Package Width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                //Ask for package height
                Console.WriteLine("Package Height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                //Ask for package length
                Console.WriteLine("Package Length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                //Calculate Dimension
                int dimension = width + height + length;
                if (dimension > 50)
                {
                    //Print error message and exit program
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                }
                else { 
                    //Calculate shipping fee
                    double result = ((width * height * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + result.ToString());
                    Console.WriteLine("Thank you!");
                }
            }

        }
    }
}
