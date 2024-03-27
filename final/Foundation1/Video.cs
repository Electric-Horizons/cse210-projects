public class Video
{
    private string title;
    private string author;
    private List<Comment> comments;
    private int runtime;

    public void InitializeVideo(string title, string author, List<Comment> comments, int runtime)
    {
        this.title = title;
        this.author = author;
        this.comments = comments; // Assign the provided list of comments
        this.runtime = runtime;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public int GetRuntime()
    {
        return runtime;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Number of comments: {GetComments().Count}");
        foreach (var comment in GetComments())
        {
            Console.WriteLine($"Comment: {comment.GetContent()}");
        }
        Console.WriteLine($"Runtime: {GetRuntime()} minutes");
    }
}