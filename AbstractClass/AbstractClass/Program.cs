namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"  
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the SayName method on the Employee object to display the name  
            employee.SayName(); // This outputs: Name: Sample Student  
        }
    }
}
