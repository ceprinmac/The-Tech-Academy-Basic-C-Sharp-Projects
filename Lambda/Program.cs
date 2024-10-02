namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees  
            List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Joe", "Smith"),
            new Employee(2, "Jane", "Doe"),
            new Employee(3, "Joe", "Johnson"),
            new Employee(4, "Alice", "Brown"),
            new Employee(5, "Bob", "Davis"),
            new Employee(6, "Charlie", "Wilson"),
            new Employee(7, "Eve", "Taylor"),
            new Employee(8, "Frank", "Anderson"),
            new Employee(9, "Grace", "Harris"),
            new Employee(10, "Hank", "Clark")
        };

            // Using foreach loop to find employees with the first name "Joe"  
            List<Employee> joesForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesForeach.Add(employee);
                }
            }

            // Display employees found with foreach  
            Console.WriteLine("Employees with the first name 'Joe' (foreach):");
            foreach (var joe in joesForeach)
            {
                Console.WriteLine($"{joe.Id}: {joe.FirstName} {joe.LastName}");
            }

            // Using lambda expression to find employees with the first name "Joe"  
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Display employees found with lambda  
            Console.WriteLine("\nEmployees with the first name 'Joe' (lambda):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"{joe.Id}: {joe.FirstName} {joe.LastName}");
            }

            // Using lambda expression to find employees with Id greater than 5  
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Display employees found with Id greater than 5  
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (var employee in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
