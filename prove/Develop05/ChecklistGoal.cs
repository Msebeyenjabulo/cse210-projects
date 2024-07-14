public class ChecklistGoal : Goal
{
    private int _requiredCompletions;
    private int _currentCompletions;
    private int _bonusPoints;

    public int RequiredCompletions { get { return _requiredCompletions; } }
    public int CurrentCompletions { get { return _currentCompletions; } }
    public int BonusPoints { get { return _bonusPoints; } }

    public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonusPoints) 
        : base(name, description, points)
    {
        _requiredCompletions = requiredCompletions;
        _currentCompletions = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCompletions < _requiredCompletions)
        {
            _currentCompletions++;
            if (_currentCompletions == _requiredCompletions)
            {
                Points += _bonusPoints;
                IsCompleted = true;
            }
        }
    }

    public override string GetStatus()
    {
        return $"{(IsCompleted ? "[X] " : "[ ] ")} {Name} (Completed {_currentCompletions}/{_requiredCompletions} times)";
    }
}
