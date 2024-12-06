using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        List<Video> videos = new List<Video>();

       
        Video video1 = new Video("Introduction to C#", "John Foxworthy", 300);
        video1.Comments.Add(new Comment("Alice", "Great tutorial!"));
        video1.Comments.Add(new Comment("Bob", "Very informative, thanks!"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "Jane DeSante's", 450);
        video2.Comments.Add(new Comment("Charlie", "This was a bit too advanced for me."));
        video2.Comments.Add(new Comment("Dave", "Fantastic content, very clear!"));
        videos.Add(video2);

        Video video3 = new Video("C# Design Patterns", "Steve Jobs", 1600);
        video3.Comments.Add(new Comment("Eve", "Love the design patterns explained here."));
        videos.Add(video3);

        Video video4 = new Video("C# and .NET Core", "Sarah Lee Harris", 700);
        video4.Comments.Add(new Comment("Frank", "Very helpful, thanks!"));
        video4.Comments.Add(new Comment("Grace", "I learned a lot."));
        video4.Comments.Add(new Comment("Hank", "The best .NET Core tutorial!"));
        videos.Add(video4);

      
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
