
    public class Entry
    {
        public string Prompt {get;}
        public string Content {get;}

        public Entry(string prompt, string content)
        {
            Prompt = prompt;
            Content = content;
        }

        public override string ToString()
        {
            return $"Prompt: {Prompt}\nEntry: {Content}\n";
        }
    }

