using Microsoft.VisualBasic;
using System;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // Create a one-dimensional array of strings  
            string[] stringArray = { "Apple", "Ball", "Cat", "Dog" };

            // Ask the user to input some text  
            Console.Write("Please enter some word: ");
            string userInput = Console.ReadLine();

            // Loop through each string in the array and append the user's input  
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput; // Append user input to each string  
            }

            // Create a second loop to print each string in the array one at a time  
            Console.WriteLine("\nModified strings:");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str); // Output each modified string  
            }

            // Assignment Part 2
            // Variables declared for loop
            int j = 0;
            bool isFull = true;

            // Loop until isFull is true
            while (isFull)
            {
                // Loop until the length of stringArray
                if (j < stringArray.Length)
                {
                    // Print userInput
                    Console.WriteLine(userInput);

                    // Ending the loop
                    if (j == stringArray.Length - 1)
                    {
                        isFull = false;
                    }
                    j++;
                }
            }

            // Assignment Part 3
            // Loop that uses "<" to continue iterating  
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Loop 1");
            }

            // Loop that uses "<=" to continue iterating  
            for (int i = 0; i <= stringArray.Length; i++)
            {
                Console.WriteLine("Loop 2");
            }

            // Assignment Part 4
            // List of string
            List<string> lost = new List<string>() { "Eyeglass", "Ballpen", "Keys", "Cellphone" };

            // User Input to search in list
            Console.WriteLine("Looking for: ");
            string search = Console.ReadLine();

            // A flag to check if the user input matches any item
            bool isFound = false;

            // Compare user input with lost list
            foreach (string item in lost)
            {
                if (item.ToLower() == search.ToLower())
                {
                    Console.WriteLine(search + " is found. Take it!");
                    isFound = true;
                    break; // Stops the loop from executing once item has been found
                }
            }

            // Check if the input was not found in the list 
            if (!isFound)
            {
                Console.WriteLine(search + " is not found. Try again later!");
            }

            // Assignment Part 5
            // List of string
            List<string> clothes = new List<string>() { "shirt", "pants", "shorts", "underwear", "socks", "pants" };

            // User Input to search in list
            Console.WriteLine("Looking for: ");
            string userSearch = Console.ReadLine();

            // A flag to check if the user input matches any item
            bool found = false;

            // Loop through the list and display the indices of matches  
            for (int i = 0; i < clothes.Count; i++)
            {
                if (clothes[i].Equals(userSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found '{userSearch}' at index: {i}");
                    found = true;
                }
            }

            // Check if the input was not found in the list  
            if (!found)
            {
                Console.WriteLine($"The input '{userInput}' is not on the list.");
            }

            // Assignment Part 6
            // List of string with some duplicates
            List<string> Ranks = new List<string>() { "Master", "Epic", "Grandmaster", "Legendary", "Mythic", "Legendary" };

            // A list to keep track of unique items
            List<string> uniqueItems = new List<string>();

            foreach (var item in Ranks) 
            {
                if (uniqueItems.Contains(item))
                {
                    // Item is a duplicate, print the message
                    Console.WriteLine(item + " - this item is a duplicate");
                }
                else
                {
                    // Item is unique, add it to the unique items list and print the message  
                    Console.WriteLine(item + " - this item is unique");
                    uniqueItems.Add(item); // Add the item to the unique list 
                }
            }
        }
    }
}
