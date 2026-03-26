using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Bake Bread", "Chef Jane", 600);
        video1.AddComment(new Comment("User123", "This was so helpful!"));
        video1.AddComment(new Comment("BakerBoy", "Mine didn't rise, any tips?"));
        video1.AddComment(new Comment("Foodie", "Best sourdough tutorial ever."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("C# Tutorial for Beginners", "Code With Me", 1200);
        video2.AddComment(new Comment("DevGal", "Finally understand classes!"));
        video2.AddComment(new Comment("StudentA", "Can you do a video on Inheritance?"));
        video2.AddComment(new Comment("BugHunter", "Great explanation of polymorphism."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Top 10 Travel Destinations 2024", "Wanderlust", 900);
        video3.AddComment(new Comment("Traveler99", "I need to go to Japan now."));
        video3.AddComment(new Comment("GlobeTrotter", "Switzerland is way too expensive."));
        video3.AddComment(new Comment("VacayMode", "Adding these to my bucket list!"));
        videos.Add(video3);

        // Displaying the data
        foreach (var video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");
            
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: \"{comment.Text}\"");
            }
        }
        Console.WriteLine("--------------------------------------------------");
    }
}