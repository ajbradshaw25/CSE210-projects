// To exceed requirements, I decided to have the program work from a library of multiple scriptures that randomizes with one loads next after you complete each one.
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Reference("Doctrine and Covenants", 25, 12, 13), "For my soul delighteth in the song  of the heart; yea, the song of the righeous is a prayer unto me, and it shall be answered with a blessing upon their heads.");
        library.AddScripture(new Reference("3 Nephi", 12, 16), "Therefore let your light so shine before this people, that they may see your good works and glorify your Father who is in heaven.");
        library.AddScripture(new Reference("Alma", 33, 21), "O my brethren, if ye could be healed by merely casting about your eyes that ye might be healed, would ye not behold quickly, or would ye rather harden your hearts in unbelief, and be slothful, that ye would not cast about your eyes, that ye might perish?");

        while (true)
        {
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}