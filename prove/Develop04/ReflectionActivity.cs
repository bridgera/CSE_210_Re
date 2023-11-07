using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        _name = "The Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    protected override void PreActivity()
    {
        
    }

    protected override void ActivityLogic()
    {
         Console.Write("\nBreathe in...");
         _animation.CountdownAnim(4);

         Console.Write("\nNow breathe out...");
         _animation.CountdownAnim(6);  
    }

}
