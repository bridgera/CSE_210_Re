using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a difficulty!:");
        Console.WriteLine("1. Easy | 2. Medium | 3. Hard");

        string choice = Console.ReadLine();

        Reference reference = new Reference();
        Scripture scripture = new Scripture();

        if (choice == "3")
        {
            reference.SetReference("1 Nephi", 3, 7);
            scripture.SetScripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        }

        else if (choice == "1")
        {
            reference.SetReference("Alma", 32, 21);
            scripture.SetScripture(reference, "Adam fell that men might be; and men are, that they might have joy.");
        }

        else if (choice == "2")
        {
            reference.SetReference("2 Nephi", 2, 25);
            scripture.SetScripture(reference, "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        }


        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words are hidden!");
                break;
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}
