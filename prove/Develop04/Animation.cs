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

public void BreathingAnimation(int loadingTime, string direction)
    {
        List<string> animationString = new List<string> 
        { 
            "|     .     |",
            "|     *     |",
            "|     |     |",
            "|    <->    |",
            "|   <-=->   |",
            "|  <-===->  |",
            "| <-=====-> |",
            "|<-=======->|",
            "|<=========>|"
            // "     .     ",
            // "     -     ",
            // "    --     ",
            // "    <>     ",
            // "    (_)    ",
            // "    {=}    ",
            // "    [{}]   ",
            // "  {[{=}]}  ",
            // " {([{=}])} ",
            // "{=|{(0)}|=}",
            // "{.|{(*)}|.}",
            // " {~|{(@)}|~}",
            // "{+|{(O)}|+}",
            // " {*|{(#)}|*}",
            // "{&|{(%)}|&}",
            // " {%|{(^)}|%}",
            // "{$|{(&)}|$}",
            // " {@|{($)}|@}",
            // "{!|{(!)}|!}",
            // " {?|{(?)}|?}"

        };

        int frameCount = animationString.Count;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(loadingTime);

        while (DateTime.Now < futureTime)
        {
            if (direction == "in")
            {
                foreach (string s in animationString)
                    {
                        Console.Write(s);
                        Thread.Sleep(loadingTime*1000/frameCount); 
// If you are reading this Brother Carter is there a better way to do this?? \/ \/ \/
                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); 
                    }
            }
            else if (direction == "out")
            {
                for (int i = animationString.Count - 1; i >= 0; i--)
                    {
                        string s = animationString[i];
                        Console.Write(s);
                        Thread.Sleep(loadingTime*1000/frameCount); 
                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); 
                    }
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