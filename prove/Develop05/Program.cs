using System;

//I really struggled on this one but tried to exceed requirements by having all data attached to users which I think ended up ruining to structure of my program. Will gladly take any feedback and help.
class Program
{
    static void Main(string[] args)
    {
        //Initializing
        Console.Clear();
        Console.Write("Please enter user >> ");
        string username = Console.ReadLine();
        User user = new User(username);
        user.LoadFiles();

        string choice = "";

        //Menu
        while(choice != "4")
        {
            Console.Clear();
            Console.WriteLine($"You have {user.GetPoints()} points!");
            Console.WriteLine("\n 1. Create New Goal");
            Console.WriteLine(" 2. Show Goals");
            Console.WriteLine(" 3. Quit");
            Console.Write(">> ");

            choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.WriteLine("What type of goal?");
                Console.WriteLine("\n 1. Simple Goal");
                Console.WriteLine(" 2. Checklist Goal");
                Console.WriteLine(" 3. Eternal Goal");
                Console.Write("\n>>");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    SimplelGoal simplelGoal = new SimplelGoal(user);
                    simplelGoal.CreateGoal();
                }

                else if (choice == "2")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(user);
                    checklistGoal.CreateGoal();
                }

                else if (choice == "3")
                {
                    EternalGoal eternalGoal = new EternalGoal(user);
                    eternalGoal.CreateGoal();
                }



            }
            else if (choice == "2")
            {
                Console.Clear();
                user.ShowGoals();               
            }
            else if (choice == "3")
            {
                Console.Clear();
                return;
            }
        }

    }

}