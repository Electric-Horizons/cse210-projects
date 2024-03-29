class OutdoorEvent : Event
{
    private string weather;

    public OutdoorEvent(string title, string description, DateTime date, string address, string weather) : base(title, description, date, address)
    {
        this.weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }
}