using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "What are you grateful for today?",
        "Who are you thankful for in your life?",
        "What events have made you happy recently?",
        "What aspects of your health are you grateful for?"
    };

    public GratitudeActivity() : base("Gratitude Activity", "This activity will help you focus on the positive aspects of your life by reflecting on things you are grateful for.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a thing you are grateful for: ");
            string item = Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");

        EndActivity();
    }
}
