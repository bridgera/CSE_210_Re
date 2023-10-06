using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class FileHandler
    {
        private char slicey = '|';
        private string directoryPath = "JournalFiles"; 

        public void SaveJournal(List<Entry> entries, string filename)
        {
            string fullPath = $"{directoryPath}\\{filename}";

            using (StreamWriter outputFile = new StreamWriter(fullPath))
            {
                foreach (Entry entry in entries)
                {
                    string line = $"{entry.Prompt}{slicey}{entry.Response}{slicey}{entry.Date}";
                    outputFile.WriteLine(line);
                }
            }
        }


        public List<Entry> LoadJournal(string filename)
        {
            
            string fullPath = $"{directoryPath}\\{filename}";

            List<Entry> loadedEntries = new List<Entry>();
            string[] lines = System.IO.File.ReadAllLines(fullPath);
            
            foreach (string line in lines)
            {

                string[] parts = line.Split("|");

                string prompt = parts[0];
                string response = parts[1];
                string date = parts[2];

                Entry freshEntry = new Entry();

                freshEntry.SetPrompt(prompt);
                freshEntry.SetResponse(response);
                freshEntry.SetDate(date);

                loadedEntries.Add(freshEntry);
            }

            return loadedEntries;
        }
    }
}
