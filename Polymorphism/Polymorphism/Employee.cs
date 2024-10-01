using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Employee : IQuittable
    {
        // Implementation of the Quit method  
        public void Quit()
        {
            // Print a message indicating that the employee has quit  
            Console.WriteLine("The employee has quit the job.");
        }
    }
}
