using System;

public class BaseGoal
{
    User user = new User("bridgerbla");
    public void CompleteGoal()
    {
        user.AddPoints(800);
        Console.WriteLine(user.GetPoints().ToString());
    }
}