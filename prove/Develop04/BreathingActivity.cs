using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(5);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(5);
        }

        EndActivity();
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
        Console.WriteLine();
    }
}
