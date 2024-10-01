namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Prince", // Set the FirstName property  
                LastName = "Macaldo",  // Set the LastName property  
                Id = 1 // Optionally set the Id property (not required by original request)  
            };

            // Call the SayName method from the Person class via the Employee object  
            employee.SayName(); // Display Fullname
        }
    }
}
