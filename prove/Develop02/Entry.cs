public class Entry
{
    public string response;
    public string prompt;
    public string date;

    public Entry(string response, string prompt, string date) 
    {
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    public Entry(string import)   
    {
        var parts = import.Split("|");
        this.prompt = parts[0];
        this.response = parts[1];
        this.date = parts[2];
    }
        // myJournal.AddEntry(new Entry("What was the most exciting thing I did today?"));
        // myJournal.AddEntry(new Entry("What things did I learn today?"));
    

    public string Export()
    {
        return $"{prompt}|{response}|{date}";
    }

    public string DisplayString()
    {
        return $"{prompt}\n {response}\n {date}\n";
    }
}