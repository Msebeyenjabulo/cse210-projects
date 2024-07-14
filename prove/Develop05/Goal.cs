public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isCompleted;

    public string Name { get { return _name; } }
    public string Description { get { return _description; } }
    public int Points { get { return _points; } }
    public bool IsCompleted { get { return _isCompleted; } }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public virtual void RecordEvent()
    {
        _isCompleted = true;
    }

    public virtual string GetStatus()
    {
        return _isCompleted ? "[X] " + _name : "[ ] " + _name;
    }
}
