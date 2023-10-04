using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class FileHandler
    {
        private char Separator = '|';
        private string directoryPath = "JournalFiles"; 

        public void SaveJournal(List<Entry> entries)
        {
            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();
            string fullPath = Path.Combine(directoryPath, filename);

            List<string> lines = new List<string>();
            foreach (Entry entry in entries)
            {
                lines.Add($"{entry.Prompt}{Separator}{entry.Response}{Separator}{entry.Date}");
            }
            File.WriteAllLines(fullPath, lines);
        }

        public List<Entry> LoadJournal()
        {
            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();
            string fullPath = Path.Combine(directoryPath, filename);

            List<Entry> loadedEntries = new List<Entry>();
            string[] lines = File.ReadAllLines(fullPath);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(Separator);
                if (parts.Length == 3)
                {
                    loadedEntries.Add(new Entry
                    {
                        Prompt = parts[0],
                        Response = parts[1],
                        Date = parts[2]
                    });
                }
            }

            return loadedEntries;
        }
    }
}
