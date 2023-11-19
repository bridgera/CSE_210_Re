using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("TestUser");

        string choice = "";

        while(choice != "4")
        {
            Console.Clear();
            Console.WriteLine($"You have {user.GetPoints} points!");
            Console.WriteLine("\n 1. Create New Goal");
            Console.WriteLine(" 2. Record Event");
            Console.WriteLine(" 3. List Goals");
            Console.WriteLine(" 4. Quit");
            Console.Write(">>");

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
                
            }
            else if (choice == "3")
            {
               
            }
            else if (choice == "4")
            {
                Console.Clear();
                return;
            }
        }

    }

}