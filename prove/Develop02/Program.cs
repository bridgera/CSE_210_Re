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
            
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add entry");
                Console.WriteLine("2. Show all entries");
                Console.WriteLine("3. Save to file");
                Console.WriteLine("4. Load from file");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    
                    Console.Write(">");
                    string response = Console.ReadLine();
                    
                    journal.Entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now.ToString("MM/dd/yyyy") });
                }
                else if (choice == "2")
                {
                    foreach (var entry in journal.Entries)
                    {
                        Console.WriteLine(entry.DisplayEntry());
                        Console.WriteLine("-----------------------------");
                    }
                }
                else if (choice == "3")
                {
                    fileHandler.SaveJournal(journal.Entries);
                }
                else if (choice == "4")
                {
                    journal.Entries = fileHandler.LoadJournal();
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
