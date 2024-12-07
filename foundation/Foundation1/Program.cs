using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video("China Nature", "Crazy Nature", 300);
        video1.AddComment(new Comment("Marcelo", "So relaxing!"));
        video1.AddComment(new Comment("Arturo", "Loved nature."));
        video1.AddComment(new Comment("Lourdes", "Love China."));

        // video 2
        Video video2 = new Video("Technological advances for 2025", "Crazy Technology", 600);
        video2.AddComment(new Comment("David", "Amazing information!"));
        video2.AddComment(new Comment("Elver", "I want those new devices."));
        video2.AddComment(new Comment("Felix", "The best for me."));
        
        // Video 3
        Video video3 = new Video("Cooking Lobster! 'Easy Recipe'", "Crazy Kitchen", 450);
        video3.AddComment(new Comment("Paula", "I'll try this recipe!"));
        video3.AddComment(new Comment("Daniela", "Looks delicious."));
        video3.AddComment(new Comment("Kevin", "Nice tips."));

        // List of "videos" 
        List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (Video video in videos) // For each video in the videos list
            {
                Console.WriteLine(video.Display()); // Display Videos information
                Console.WriteLine("-------------------------------------------\n"); 
            }
    }
}


