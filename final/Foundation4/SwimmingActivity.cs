class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60; // mph
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }
}