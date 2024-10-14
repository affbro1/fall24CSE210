using System;
using System.IO;

    public class Journal
    {
        Entry[] entries = new Entry[0];

        public void AddEntry(Entry entry)
        {
            Array.Resize(ref entries, entries.Length + 1);
            entries[entries.Length - 1] = entry;
        }

        public void DisplayEntries()
        {
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }
        }

        public void SaveEntries(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                for (int i = 0; i < entries.Length; i++)
                {
                    writer.WriteLine($"{entries[i].Prompt}|{entries[i].Content}");
                }
            }
        }

        public void LoadEntries(string filename)
        {
            if (File.Exists(filename))
            {
                entries = new Entry[0];
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                using (StreamReader reader = new StreamReader(fs))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            var entry = new Entry(parts[0], parts[1]);
                            AddEntry(entry);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
