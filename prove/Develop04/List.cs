// Listening.cs
using System;

public class List : Activity
{
    public List() : base("Listening") { }

    public override void Start()
    {
        ShowWelcomeMessage();

        Console.WriteLine("Respond to the prompt as many times in the alloted time.");
        Console.WriteLine("How long would you like to do this activity (in seconds)?");
        int duration = int.Parse(Console.ReadLine());

        int timeLeft = duration;
        int responseCount = 0;

        while (timeLeft > 0)
        {



            Console.WriteLine("When have you felt the holy ghost this month?");
            string response = Console.ReadLine();

            if (!string.IsNullOrEmpty(response))
            {
                responseCount++;
            }

        }


        Console.WriteLine($"You gave {responseCount} responses during the List activity.");
        ShowGoodbyeMessage();
    }
}
