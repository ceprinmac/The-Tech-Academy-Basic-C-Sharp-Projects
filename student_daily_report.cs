using System;

class Program
{
    static void Main()
    {
        // Print the name of the academy  
        Console.WriteLine("The Tech Academy. \nStudent Daily Report.");

        // Ask for the student's name 
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        // Ask for the course name 
        Console.Write("What course are you on? ");
        string course = Console.ReadLine();

        // Ask for the page number, converting the response it to an integer  
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        // Ask if the student needs help 
        Console.Write("Do you need help with anything? Please answer “true” or “false.” ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        // Ask for any positive experiences
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics. ");
        string positiveExperience = Console.ReadLine();

        // Ask for additional feedback  
        Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
        string feedback = Console.ReadLine();

        // Ask for the number of hours studied 
        Console.Write("How many hours did you study today? ");
        double studyHours = Convert.ToDouble(Console.ReadLine());

        // Thank the user for their input  
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}
