using System;

class Program
{
    static void Main(string[] args)
    {
        GoalsTracker tracker = new GoalsTracker();
        string menuChoice = "";

        while (menuChoice != "6")
        {
            tracker.ListGoals();
            Console.WriteLine($"Total Points: {tracker.GetAccumulatedPoints()}\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Simple Goal");
            Console.WriteLine("2. Create New Eternal Goal");
            Console.WriteLine("3. Create New Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit Program");
            Console.Write("Choose an option: ");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Goal simpleGoal = new SimpleGoal("", "", 0, false);
                    simpleGoal.CreateChildGoal();
                    tracker.AddGoal(simpleGoal);
                    break;
                case "2":
                    Goal eternalGoal = new EternalGoal("", "", 0);
                    eternalGoal.CreateChildGoal();
                    tracker.AddGoal(eternalGoal);
                    break;
                case "3":
                    Goal checklistGoal = new ChecklistGoal("", "", 0, 0, 0);
                    checklistGoal.CreateChildGoal();
                    tracker.AddGoal(checklistGoal);
                    break;
                case "4":
                    tracker.RecordEventInTracker();
                    break;
                case "5":
                    tracker.SaveGoals();
                    break;
                case "6":
                    tracker.LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
