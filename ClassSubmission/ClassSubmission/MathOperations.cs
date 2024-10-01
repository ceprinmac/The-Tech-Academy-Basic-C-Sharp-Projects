using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassSubmission
{
    public static class MathOperations
    {
        public static void Division(int a)
        {
            int result = a / 2;

            Console.WriteLine($"The result of {a} divided by 2 is: {result}");
        }

        public static void Division(int a, out int result)
        {
            result = a / 2;
        }

        // Overloaded method to divide a floating-point number by 2  
        public static void Division(double a)
        {
            // Calculate the result of dividing the floating-point number by 2  
            double result = a / 2;
            // Output the result to the console  
            Console.WriteLine($"The result of {a} divided by 2 is: {result}");
        }
    }
}
