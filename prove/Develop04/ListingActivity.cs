using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userItems.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {userItems.Count} items!");
    }
}