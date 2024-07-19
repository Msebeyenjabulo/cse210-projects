public class Cycling : Activity
{
    public double Speed { get; set; } // in mph
    
    public Cycling(string date, int length, double speed)
        : base(date, length)
    {
        Speed = speed;
    }
    
    public override double GetSpeed()
    {
        return Speed;
    }
    
    public override double GetDistance()
    {
        return Speed * (Length / 60.0);
    }
    
    public override double GetPace()
    {
        return Length / GetDistance();
    }
    
    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Speed: {GetSpeed()} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min/mile";
    }
}