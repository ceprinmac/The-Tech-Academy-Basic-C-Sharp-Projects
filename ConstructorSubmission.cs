namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a constant variable. 
            const int ConstantValue = 10;

            // Declare a variable using the var keyword. 
            var variableValue = 20; 

            // Call a method that chains two constructors together.  
            // In this example, we will create an instances of MyClass which has overloaded constructors.  
            MyClass myObject = new MyClass(5).AddToValue(10);

            // Output the result to the console  
            Console.WriteLine(myObject.Value);
        }
    }

    class MyClass
    {
        // Property to hold a value  
        public int Value { get; set; }

        // Constructor that accepts an integer parameter to initialize Value  
        public MyClass(int inputValue)
        {
            Value = inputValue; // Set the Value property to the input value.  
        }

        // Method that adds a specified amount to the Value and returns the object itself  
        public MyClass AddToValue(int addValue)
        {
            Value += addValue; // Update the Value by adding addValue.  
            return this; // Return the current instance for method chaining.  
        }
    }
}
