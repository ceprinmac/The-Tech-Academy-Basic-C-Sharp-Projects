using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class MathOperations
    {
        public void Addition(int a, int b)
        {
            // Perform a math operation on the first integer  
            int res = a + 10;

            // Display the second integer to the screen  
            Console.WriteLine($"The result after adding 10 to {a} is: {res}");
            Console.WriteLine($"The second number is: {b}");
        }
    }
}
