using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to paint a galaxy", "Art Inspirations", 1800);
        video1.AddComment(new Comment("User123", "This was so beautiful!"));
        video1.AddComment(new Comment("BakerBoy", "So Inspiring!"));
        video1.AddComment(new Comment("ArtSplash", "Best painting tutorial ever."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to stargaze and find well known constellations", "Stargazer", 1200);
        video2.AddComment(new Comment("Astro462", "I finally understand stargazing!"));
        video2.AddComment(new Comment("user127", "Can you do a video on how to find some of the planets in the night sky?"));
        video2.AddComment(new Comment("Cometchaser", "Great explanation on stargazing."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to bake Butterscotch Cake", "Chloe Bakes", 900);
        video3.AddComment(new Comment("Bakergal", "This was so helpful!"));
        video3.AddComment(new Comment("user235", "Mine turned out uneven, any tips on how to fix that?"));
        video3.AddComment(new Comment("Recipes73", "Adding these to my recipe list!"));
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