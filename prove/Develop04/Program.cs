using System;

// EXCEEDED REQUIREMENTS by making sure prompts don't repeat in the reflection activity.
class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while(choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();


            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunActivity();
            }
            else if (choice == "4")
            {
                Console.Clear();
                return;
            }
        }
        
    }
}
