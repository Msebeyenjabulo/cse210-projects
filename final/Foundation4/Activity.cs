public class Activity
{
    public string Date { get; set; }
    public int Length { get; set; } // in minutes
    
    public Activity(string date, int length)
    {
        Date = date;
        Length = length;
    }
    
    public virtual string GetSummary()
    {
        return $"Date: {Date}, Length: {Length} minutes";
    }
    
    public virtual double GetDistance()
    {
        return 0;
    }
    
    public virtual double GetSpeed()
    {
        return 0;
    }
    
    public virtual double GetPace()
    {
        return 0;
    }
}