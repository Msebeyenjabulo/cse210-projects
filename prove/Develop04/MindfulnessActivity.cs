using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    public string ActivityName { get; private set; }
    protected string Description;
    protected int Duration;

    public MindfulnessActivity(string activityName, string description)
    {
        ActivityName = activityName;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {ActivityName}.");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {ActivityName}");
        Console.WriteLine($"Duration: {Duration} seconds");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity();
}
