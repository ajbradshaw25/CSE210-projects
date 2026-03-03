using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        BreathingActivity a2 = new BreathingActivity("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        ReflectingActivity a3 = new ReflectingActivity("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        ListingActivity a3 = new ListingActivity("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        AwarenessActivity a3 = new AwarenessActivity("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int userChoice = -1;

        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (userChoice != 5)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Awareness Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option from the menu: ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string prompt = promptGenerator.Prompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userResponse = Console.ReadLine();

                Console.Write("What was your general mood today? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = userResponse;
                newEntry._mood = mood;

                myJournal.AddEntry(newEntry);
            }
            else if (userChoice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("Load from what filename? ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (userChoice == 4)
            {
                Console.Write("Save to what filename? ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
        }
    }
}