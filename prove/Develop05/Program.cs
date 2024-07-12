class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));

        // Simulate some events
        goalManager.RecordEvent(0); // Mark the marathon goal as complete
        goalManager.RecordEvent(1); // Record an instance of reading scriptures
        goalManager.RecordEvent(2); // Record an instance of attending the temple

        // Display goals and score
        goalManager.DisplayGoals();
        goalManager.DisplayScore();

        // Save and load goals
        goalManager.SaveGoals("goals.txt");
        goalManager.LoadGoals("goals.txt");
    }
}
