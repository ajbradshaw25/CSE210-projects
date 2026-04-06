using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;
        Console.WriteLine("Welcome to  the Mindfulness Program!");

        while (userChoice != 4)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please select an option from the menu: ");
            
            userChoice = int.Parse(Console.ReadLine());
            Activity activity = null;


            if (userChoice == 1)
            {
                activity = new BreathingActivity();
            }
            else if (userChoice == 2)
            {
                activity = new ReflectionActivity();
            }
            else if (userChoice == 3)
            {
                activity = new ListingActivity();
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            activity?.Run();
        }
    }
}