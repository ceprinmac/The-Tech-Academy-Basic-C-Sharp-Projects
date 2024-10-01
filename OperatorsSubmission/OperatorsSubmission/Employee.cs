using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Operator overload for '=='   
        public static bool operator ==(Employee a, Employee b)
        { 
            return a.Id == b.Id; // Compare Id properties  
        }

        // Operator overload for '!='  
        public static bool operator !=(Employee a, Employee b)
        {
            return !(a == b); // Call the '==' operator  
        }

    }
}
