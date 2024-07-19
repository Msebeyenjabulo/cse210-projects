public class Swimming : Activity
{
    public int Laps { get; set; }
    public double LapLength { get; set; } // in meters
    
    public Swimming(string date, int length, int laps, double lapLength = 50)
        : base(date, length)
    {
        Laps = laps;
        LapLength = lapLength;
    }
    
    public override double GetDistance()
    {
        return (Laps * LapLength) / 1609.34; // convert meters to miles
    }
    
    public override double GetSpeed()
    {
        return GetDistance() / (Length / 60.0);
    }
    
    public override double GetPace()
    {
        return Length / GetDistance();
    }
    
    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Laps: {Laps}, Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
