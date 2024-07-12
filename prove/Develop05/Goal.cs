public abstract class Goal
{
    protected string name;
    protected int points;

    public abstract void RecordEvent();
    public abstract string GetDetails();
    public int GetPoints() => points;
}

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
        }
    }

    public override string GetDetails()
    {
        return isComplete ? $"{name} [X]" : $"{name} [ ]";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public override void RecordEvent()
    {
        // Always earns points, never completes
    }

    public override string GetDetails()
    {
        return $"{name} (Eternal)";
    }
}

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
    {
        this.name = name;
        this.points = points;
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
        }
    }

    public override string GetDetails()
    {
        return $"{name} [Completed {currentCount}/{targetCount}]";
    }
}
