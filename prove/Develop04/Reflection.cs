// Reflection.cs
using System;

public class Reflection : Activity
{
    //promt list
    private string[] prompts = new string[]
    {
        "Think of a time when you did something really difficult.",
        "Think of a moment when you felt proud of yourself.",
        "Think of a person who has inspired you and why.",
        "Reflect on a challenge you overcame in the past."
    };
    //question list 
    private string[] questions = new string[]
    {
        "What was the hardest part of that experience?",
        "What did you learn from that moment?",
        "How did you feel at the time?",
        "What would you do differently next time?",
        "What skills did you develop?",
        "What might you have done differently?"
    };

    public Reflection() : base("Reflection") { }

    public override void Start()
    //provide a promt and then give a question after every few seconds
    {
        ShowWelcomeMessage();

        Console.WriteLine("You'll be given prompts and reflection questions every few seconds. There is no need to respond to them on the console.");
        Console.WriteLine("How long would you like to do this activity (in seconds)?");
        int duration = int.Parse(Console.ReadLine());

        int timeLeft = duration;
        Random random = new Random();

        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        System.Threading.Thread.Sleep(8000); 

        while (timeLeft > 0)
        {

            Console.WriteLine(questions[random.Next(questions.Length)]);
            System.Threading.Thread.Sleep(8000); 
            timeLeft -= 8;
        }

        ShowGoodbyeMessage();
    }
}
