public class Running : Activity
{
    public double Distance { get; set; } // in miles
    
    public Running(string date, int length, double distance)
        : base(date, length)
    {
        Distance = distance;
    }
    
    public override double GetDistance()
    {
        return Distance;
    }
    
    public override double GetSpeed()
    {
        return Distance / (Length / 60.0);
    }
    
    public override double GetPace()
    {
        return Length / Distance;
    }
    
    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}