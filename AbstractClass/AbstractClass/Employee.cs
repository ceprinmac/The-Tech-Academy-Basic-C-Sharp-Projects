using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        // Implementation of the SayName method specific to the Employee class 
        public override void SayName() 
        {
            // Display the full name of the employee  
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
