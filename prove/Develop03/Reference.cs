public class Reference
{
    private string book;
    private int chapter;
    private int verse;

    public Reference(string bookChoice, int chapterChoice, int verseChoice)
    {
        book = bookChoice;
        chapter = chapterChoice;
        verse = verseChoice;
    }

    public string GetDisplayText()
    {
        string memorizeThisKid = $"{book} {chapter}:{verse}";
        return memorizeThisKid;
    }
}
