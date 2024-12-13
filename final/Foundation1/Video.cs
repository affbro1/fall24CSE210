using System;
using System.Collections.Generic;

public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int LengthInSeconds {get; set;}
    public int Upvotes {get; set;}
    public List<Comment> Comments {get; set;}

   
    public Video(string title, string author, int lengthInSeconds, int upvotes)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
        Upvotes = upvotes; 
    }

    
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Upvotes: {Upvotes}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");


        foreach (var comment in Comments)
        {
            Console.WriteLine($"    {comment.Name} - {comment.Text}");
        }
        Console.WriteLine();  
    }
}
