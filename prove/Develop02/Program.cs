using System;

    class Program
    {
        private static Journal journal = new Journal();
        private static Prompt promptGenerator = new Prompt();

        static void Main(string[] args)
        {
            Run();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }

        private static void Run()
        {
            while (true)
            {
                DisplayMenu();
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string promptText = promptGenerator.GetRandomPrompt();
                        Console.WriteLine(promptText);
                        Console.Write("Your entry: ");
                        string content = Console.ReadLine();
                        Entry entry = new Entry(promptText, content);
                        journal.AddEntry(entry);
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter a filename to load: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadEntries(loadFilename);
                        Console.Write("Loaded!");
                        break;

                    case "4":
                        Console.Write("Enter a filename to save as: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveEntries(saveFilename);
                        Console.Write("Saved!");
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

