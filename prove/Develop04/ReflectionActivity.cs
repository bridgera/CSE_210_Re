using System;

public class ReflectionActivity : Activity
{
    // Listssssss
    private List<string> _reflections = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
     {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?" 
    };

    //Constructor
    public ReflectionActivity()
    {
        _name = "The Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }


    protected override void PreActivity()
    {
        string reflection = RandomPromptSelection(_reflections);

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n---{reflection}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        _animation.CountdownAnim(5);
        Console.Clear();
    }

    protected override void ActivityLogic()
    {
        string question = RandomPromptSelection(_questions);

        if (question != null)
        {
            Console.Write($"> {question}\n");
            _animation.LoadingAnimation(5); 
        }
        else
        {
            _animation.LoadingAnimation(1);
        }
         
    }

}
