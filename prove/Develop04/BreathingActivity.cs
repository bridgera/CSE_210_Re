using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "The Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void ActivityLogic()
    {
         Console.Write("\nBreathe in...");
         _animation.CountdownAnim(4);

         Console.Write("\nNow breathe out...");
         _animation.CountdownAnim(6);  
    }

}
