class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("2024-07-10", 30, 3.5);
        Cycling cycling = new Cycling("2024-07-11", 45, 15.0);
        Swimming swimming = new Swimming("2024-07-12", 60, 40);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
