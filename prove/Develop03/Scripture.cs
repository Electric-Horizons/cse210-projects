public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;

        // Create a temporary list to hold the words
        List<string> wordsAsStrings = verseText.Split(' ').ToList();

        // Create a list of Word objects from the temporary list
        _words = new List<Word>();
        foreach (string word in wordsAsStrings)
        {
            _words.Add(new Word(word));
        }
    }

    public Reference Reference => _reference;
    // public Reference(Reference reference) 
    // {
    //     this._reference = reference;
    //     return reference
    // }

    public string GetText()
    {
        // Build the display text by combining the display text of each Word object
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public void HideRandomWords(int numWords)
    {
        Random random = new Random();
        for (int i = 0; i < numWords; i++)
        {
            int wordIndex = random.Next(_words.Count);
            _words[wordIndex].IsHidden = true;
        }
    }

    // public void HideRandomWords(int numWords)
    // {
    //     // Use a Random object to choose words to hide
    //     Random random = new Random();

    //     // Hide the specified number of words, ensuring no word is hidden twice
    //     int uniqueHides = 0;
    //     while (uniqueHides < numWords)
    //     {
    //         // Get a random word index
    //         int wordIndex = random.Next(_words.Count);

    //         // Skip hiding already hidden words
    //         if (!_words[wordIndex].IsHidden)
    //         {
    //             _words[wordIndex].IsHidden = true;
    //             uniqueHides++;
    //         }
    //     }
    // }
}