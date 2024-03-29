class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string address;

    public Event(string title, string description, DateTime date, string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {date.ToShortTimeString()}\nAddress: {address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}