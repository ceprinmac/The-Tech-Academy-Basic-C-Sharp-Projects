namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable using Employee class  
            IQuittable employee = new Employee();

            // Call the Quit method on the IQuittable object  
            employee.Quit();

        }
    }
}
