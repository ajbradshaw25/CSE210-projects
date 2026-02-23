using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

                string prompt = promptGenerator.Prompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userResponse = Console.ReadLine();

                Console.Write("Press enter to continue or type 'quit' to finish: ");
                string mood = Console.ReadLine();
    }
}