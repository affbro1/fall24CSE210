// Activity.cs
using System;

public abstract class Activity
{
     // Duration in seconds
    public int Duration { get; set; }
    public string Name { get; set; }

    public Activity(string name)
    {
        Name = name;
    }


    public abstract void Start();


    protected void ShowWelcomeMessage()
    {

        Console.WriteLine($"Welcome to the {Name} activity!");
    }

    // Method to display the goodbye message for the activity
    protected void ShowGoodbyeMessage()
    {

        Console.WriteLine($"Good job! You've completed the {Name} activity.");
    }

    // Common spinner display method
    protected void ShowSpinner()
    {
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }
}
