using System;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            FileHandler fileHandler = new FileHandler();
            PromptGenerator promptGenerator = new PromptGenerator();
            string choice = "";
            
            while (choice != "5")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add entry");
                Console.WriteLine("2. Show all entries");
                Console.WriteLine("3. Save to file");
                Console.WriteLine("4. Load from file");
                Console.WriteLine("5. Exit");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    
                    Console.Write(">");
                    string response = Console.ReadLine();
                    
                    Entry newEntry = new Entry();
                    newEntry.SetPrompt(prompt);
                    newEntry.SetResponse(response);
                    newEntry.SetDate();
                    
                    journal.AddEntry(newEntry);
                }
                else if (choice == "2")
                {
                    foreach (Entry entry in journal.Entries)
                    {
                        entry.DisplayEntry();
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Enter filename:");
                    string filename = Console.ReadLine();
                    fileHandler.SaveJournal(journal.Entries, filename);
                    
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Enter filename:");
                    string filename = Console.ReadLine();
                    journal.Entries = fileHandler.LoadJournal(filename);
                }
                else if (choice == "5")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }
        }
    }
}
