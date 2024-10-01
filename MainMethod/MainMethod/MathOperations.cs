using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOperations
    {
        // Method to add 1 to the int variable
        public int Addition(int a)
        {
            return a + 1;
        }
        // Accepting double variable to operate
        public int Addition(double a)
        {
            return ((int)a) + 10;
        }
        // Accepting string variable to operate
        public int Addition(string a)
        {
            return Convert.ToInt32(a) + 20;
        }
    }
}
