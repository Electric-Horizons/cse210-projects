public class Word
{
    private string _text;
    public bool IsHidden;

    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }

    public string Text => _text;

    public string GetDisplayText() => IsHidden ? "____" : Text;
}

