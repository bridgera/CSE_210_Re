using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class FileHandler
    {
        private char _slicey = '|';
        private string _directoryPath = "JournalFiles"; 


        public void SaveJournal(List<Entry> entries, string filename)
        {
            string fullPath = $"{_directoryPath}\\{filename}";

            using (StreamWriter outputFile = new StreamWriter(fullPath))
            {
                foreach (Entry entry in entries)
                {
                    string line = $"{entry._prompt}{_slicey}{entry._response}{_slicey}{entry._date}";
                    outputFile.WriteLine(line);
                }
            } 
        }


        public List<Entry> LoadJournal(string filename)
        {
            bool fileExists = false;

            List<Entry> loadedEntries = new List<Entry>();

            while(fileExists != true)
            {
                string fullPath = $"{_directoryPath}\\{filename}";

                if (File.Exists(fullPath))
                {
                    fileExists = true;

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

                }
                else
                {
                    Console.WriteLine("Please enter a valid file name");
                }
            }

            return loadedEntries;
        }
    }
}
