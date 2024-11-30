using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Add the comments to each video 
        Video video1 = new Video("China Nature", "Crazy Nature", 300);
        video1.AddComment(new Comment("Marcelo", "So relaxing!"));
        video1.AddComment(new Comment("Arturo", "Loved nature."));
        video1.AddComment(new Comment("Lourdes", "Love China."));

        Video video2 = new Video("Technological advances for 2025", "Crazy Technology", 600);
        video2.AddComment(new Comment("David", "Amazing information!"));
        video2.AddComment(new Comment("Elver", "I want those new devices."));
        video2.AddComment(new Comment("Felix", "The best for me."));

        Video video3 = new Video("Cooking Lobster! 'Easy Recipe'", "Crazy Kitchen", 450);
        video3.AddComment(new Comment("Paula", "I'll try this recipe!"));
        video3.AddComment(new Comment("Daniela", "Looks delicious."));
        video3.AddComment(new Comment("Kevin", "Nice tips."));

        // List of "videos" 
        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            // Display Video information
            Console.WriteLine($"---------------------------------------\n");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Comments Count: {video.GetCommentCount()}"); // Comment count

            // Display Comments information
            Console.WriteLine("\nComments:");
            // For each comment in the comments video list 
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"\n- {comment.Name}: {comment.Text}\n");
            }
        }
    }
}


