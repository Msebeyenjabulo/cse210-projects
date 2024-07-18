public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // eternal goals are never fully completed, only recorded
    }

    public override string GetStatus()
    {
        return "[E] " + Name;
    }
}
