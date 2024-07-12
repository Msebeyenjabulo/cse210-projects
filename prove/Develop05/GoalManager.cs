public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        goals[goalIndex].RecordEvent();
        score += goals[goalIndex].GetPoints();
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetDetails());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Parse and create goals from file
            }
        }
    }
}
