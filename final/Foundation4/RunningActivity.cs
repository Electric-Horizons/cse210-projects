class RunningActivity : Activity
{
    private double distance; // in miles

    public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / duration) * 60; // mph
    }

    public override double GetPace()
    {
        return duration / distance;
    }
}
