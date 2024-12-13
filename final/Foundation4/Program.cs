using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2024, 12, 18), 30, 3);
        Cycling cycling = new Cycling(new DateTime(2024, 12, 18), 45, 12);
        Swimming swimming = new Swimming(new DateTime(2024, 12, 18), 40, 50);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}
