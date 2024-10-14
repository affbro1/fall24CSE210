using System;


    public class Prompt
    {
        private string[] prompts = {
            "What are you grateful for today?",
            "Describe a moment that made you smile.",
            "What challenges did you face today?",
            "What do you wish to achieve tomorrow?",
            "Reflect on a memory that brings you joy.",
            "What is one lesson you've learned from a mistake you've made?",
            "What is something you wish you could change about your routine?",
            "What are three things you love about yourself?"
        };

        public string GetRandomPrompt()
        {
            Random random = new Random();
            return prompts[random.Next(prompts.Length)];
        }
    }

