using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

//Create anim instance
    protected Animation _animation = new Animation();

    public void RunActivity()
    {
        StartMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime) 
        {
            ActivityLogic();
        }

        EndMessage();
    }

    protected void ActivityLogic()
    {

    }

    protected void SetDuration()
    {
        Console.Write($"Enter the duration for the {_name} in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n\n{_description}\n");
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        _animation.LoadingAnimation(3);
    }

    protected void EndMessage()
    {
        Console.WriteLine("\n\nWell done!");
        _animation.LoadingAnimation(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name}!");
        _animation.LoadingAnimation(5);
    }

}
