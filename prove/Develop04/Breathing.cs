// Breathing.cs
using System;

public class Breathing : Activity
{
    public Breathing() : base("Breathing") { }

    public override void Start()
    {
        ShowWelcomeMessage();

        Console.WriteLine("Inhale for 4 seconds, then exhale for 5 seconds.");
        Console.WriteLine("How long would you like to do this activity (in seconds)?");
        int duration = int.Parse(Console.ReadLine());

        int timeLeft = duration;
        while (timeLeft > 0)
        {

            Console.WriteLine("Breathe in...");
            Console.Write("4");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000); 
            Console.WriteLine("");
            timeLeft -= 4;
            if (timeLeft <= 0) break;

            Console.WriteLine();
            Console.WriteLine("Now breathe out");
            Console.Write("5");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000); 
            Console.WriteLine("");
            timeLeft -= 5;
        }

        ShowGoodbyeMessage();
    }
}
