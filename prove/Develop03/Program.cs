using System;

    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Press Enter to get a random scripture or type 'quit' to exit:");
                var input = Console.ReadLine();
                
                if (input.ToLower() == "quit")
                {
                    running = false;
                }
                else
                {
                    var scripture = reference.GetRandomScripture();
                    scripture.DisplayAndMemorize();
                }
            }
        }
    }

