namespace MethodClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class  
            MathOperations mathOps = new MathOperations();

            // Call the Addition method, passing in two numbers  
            mathOps.Addition(5, 20);

            // Call the Addition method, specifying the parameters by name  
            mathOps.Addition(a: 10, b: 30);
        }
    }
}
