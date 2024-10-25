using System;

    class Word
    {
        private string[] wordArray;
        private bool[] wordList;

        public Word(string[] wordArray, bool[] wordList)
        {
            this.wordArray = wordArray;
            this.wordList = wordList;
        }

        public void StartMemorization()
        {
            Console.WriteLine("Press Enter to start memorization.");
            Console.ReadLine();

            Random rand = new Random();
            int wordsCount = wordArray.Length;
            int erasedWords = 0;

            while (erasedWords < wordsCount)
            {
                int randomIndex = rand.Next(wordsCount);
                if (!wordList[randomIndex])
                {
                    wordList[randomIndex] = true;
                    DisplayVerseWithBlank(randomIndex);
                    erasedWords++;
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Congratulations!");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }

        private void DisplayVerseWithBlank(int index)
        {
            
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordList[i])
                {
                    Console.Write(new string('_', wordArray[i].Length) + " ");
                }
                else
                {
                    Console.Write(wordArray[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }

