using System;

public class ListingActivity : Activity
{
//Attributes
    private int _count = 0;
    private List<string> _questions = new List<string>
     {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

// Constructor
    public ListingActivity()
    {
        _name = "The Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

// Actual activity
    protected override void PreActivity()
    {
        string question = RandomPromptSelection(_questions);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"---{question}---");
        Console.Write("You may begin in: ");
        _animation.CountdownAnim(5);
        Console.WriteLine("");
    }

    protected override void ActivityLogic()
    {
        Console.Write(">");
        Console.ReadLine();
        _count = _count + 1;
    }

    protected override void PostActivity()
    {
        _animation.LoadingAnimation(2);
        Console.WriteLine($"\n----You listed {_count} items!---");
    }

}
