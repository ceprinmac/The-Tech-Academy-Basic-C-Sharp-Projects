using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTwoParameters
{
    public class MathOperations
    {
        public int Subtraction(int a, int b = 0) 
        { 
            return a - b; 
        }
    }
}
