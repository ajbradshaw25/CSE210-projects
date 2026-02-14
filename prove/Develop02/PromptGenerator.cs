using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    public List<string> _prompts = [
        "What is something that made you smile today? ",
        "What made you sad today? ",
        "What is something you learned about today? ",
        "How did you see the Lord in your life today? ",
        "What was the strongest emotion you felt today? "
    ];

    public string Prompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomString = _prompts[index];
        return randomString;
    }
}