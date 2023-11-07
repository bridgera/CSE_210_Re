using System;

public class Animation
{
    
//Loading Anim//
    public void LoadingAnimation(int loadingTime)
    {
        List<string> animationString = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(loadingTime);

        while (DateTime.Now < futureTime)
        {
            foreach (string s in animationString)
            {
                Console.Write(s);
                Thread.Sleep(200); 
                Console.Write("\b \b"); 
            }
        }
    }


//Countdown Anim//
    public void CountdownAnim(int time)
    {
        for (int i = time; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}