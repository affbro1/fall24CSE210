using System;

    class Scripture
    {
        public string ReferenceText { get; }
        public string Text { get; }
        private string[] wordArray;
        private bool[] wordList;

        public Scripture(string referenceText, string text)
        {
            ReferenceText = referenceText;
            Text = text;
            CreateWordArray();
        }

        private void CreateWordArray()
        {
            wordArray = Text.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            wordList = new bool[wordArray.Length];
        }

        public void DisplayAndMemorize()
        {
            
            Console.WriteLine(ReferenceText);
            Console.WriteLine(Text);
            Console.WriteLine();
            Word wordHandler = new Word(wordArray, wordList);
            wordHandler.StartMemorization();
        }
    }

