namespace OperatorsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects  
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects  
            bool areEqual = emp1 == emp2;
            bool areNotEqual = emp1 != emp2;

            // Display the results  
            Console.WriteLine($"Are emp1 and emp2 equal? {areEqual}");
            Console.WriteLine($"Are emp1 and emp2 not equal? {areNotEqual}");
        }
    }
}
