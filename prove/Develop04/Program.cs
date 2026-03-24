using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (userChoice != 5)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please select an option from the menu: ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1 || userChoice == 2 || userChoice == 3)
            {
                Console.Write("Enter the duration in seconds: ");
                if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
                {
                    if (userChoice == 1)
                    {
                        BreathingActivity breathingActivity = new BreathingActivity(duration);
                        breathingActivity.StartActivity();
                    }
                    else if (userChoice == 2)
                    {
                        ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
                        reflectionActivity.StartActivity();
                    }
                    else if (userChoice == 3)
                    {
                        ListingActivity listingActivity = new ListingActivity(duration);
                        List<string> items = listingActivity.ListItems();
                        Console.WriteLine($"You listed {items.Count} items.");
                        listingActivity.StartActivity();
                    }
                    else if (userChoice == 4)
                    {
                    Console.WriteLine("Goodbye!");
                        break;
                    }
                }
            }
        }
    }
}