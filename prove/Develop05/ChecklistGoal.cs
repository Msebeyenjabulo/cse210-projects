public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; }
    public int CurrentCompletions { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonusPoints) 
        : base(name, description, points)
    {
        RequiredCompletions = requiredCompletions;
        CurrentCompletions = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (CurrentCompletions < RequiredCompletions)
        {
            CurrentCompletions++;
            if (CurrentCompletions == RequiredCompletions)
            {
                Points += BonusPoints;
                IsCompleted = true;
            }
        }
    }

    public override string GetStatus()
    {
        return $"{(IsCompleted ? "[X] " : "[ ] ")} {Name} (Completed {CurrentCompletions}/{RequiredCompletions} times)";
    }
}
