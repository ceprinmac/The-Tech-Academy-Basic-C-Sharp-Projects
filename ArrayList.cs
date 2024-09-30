namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings  
            string[] stringArray = { "Apple", "Banana", "Cherry", "Durian", "Elderberry" };

            // Ask the user to select an index for the string array  
            Console.WriteLine("Select an index (0-4) for the string array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index is valid and display the string at that index  
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                // Notify the user if the index is out of bounds  
                Console.WriteLine("Index does not exist in the string array.");
            }

            // Create a one-dimensional array of integers  
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index for the integer array  
            Console.WriteLine("Select an index (0-4) for the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index is valid and display the integer at that index  
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                // Notify the user if the index is out of bounds  
                Console.WriteLine("Index does not exist in the integer array.");
            }

            // Create a list of strings  
            List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

            // Ask the user to select an index for the list  
            Console.WriteLine("Select an index (0-4) for the string list:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index is valid and display the content at that index  
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("You selected: " + stringList[listIndex]);
            }
            else
            {
                // Notify the user if the index is out of bounds  
                Console.WriteLine("Index does not exist in the string list.");
            }

            // Prevent the console from closing immediately  
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
