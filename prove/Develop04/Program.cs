using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    public static void Main()
    {
        LoadLog();

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an activity: ");
            int choice = int.Parse(Console.ReadLine());

            MindfulnessActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    activity = new GratitudeActivity();
                    break;
                case 5:
                    SaveLog();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.PerformActivity();
            LogActivity(activity.ActivityName);
        }
    }

    private static void LoadLog()
    {
        if (File.Exists("activityLog.txt"))
        {
            string[] lines = File.ReadAllLines("activityLog.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string activityName = parts[0];
                    int count = int.Parse(parts[1]);
                    activityLog[activityName] = count;
                }
            }
        }
    }

    private static void SaveLog()
    {
        List<string> lines = new List<string>();
        foreach (var entry in activityLog)
        {
            lines.Add($"{entry.Key}:{entry.Value}");
        }
        File.WriteAllLines("activityLog.txt", lines);
    }

    private static void LogActivity(string activityName)
    {
        if (activityLog.ContainsKey(activityName))
        {
            activityLog[activityName]++;
        }
        else
        {
            activityLog[activityName] = 1;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
