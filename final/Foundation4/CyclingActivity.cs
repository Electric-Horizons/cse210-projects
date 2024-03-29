class CyclingActivity : Activity
{
    private double speed; // in mph

    public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return duration / 60 * speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}