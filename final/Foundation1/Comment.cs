public class Comment
{
    private string content;
    private string author;
    private DateTime timestamp;

    public Comment(string content, string author = null)
    {
        this.content = content;
        this.author = author ?? "Anonymous";
        this.timestamp = DateTime.Now;
    }

    public string GetContent()
    {
        return content;
    }

    public string GetFormattedContent()
    {
        return $"[{timestamp}] {author}: {content}";
    }
}