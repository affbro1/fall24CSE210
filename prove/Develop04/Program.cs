// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a menu to select an activity
        while (true)
        {

            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. List");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            Activity selectedActivity = null;

            switch (choice)
            {
                case "1":
                    selectedActivity = new Breathing();
                    break;
                case "2":
                    selectedActivity = new Reflection();
                    break;
                case "3":
                    selectedActivity = new List();
                    break;
                case "4":
                    return; 
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
            }


            selectedActivity.Start();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
