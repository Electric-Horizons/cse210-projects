public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("Esther", 8, 9);
        Scripture scripture = new Scripture(reference, "Then were the king’s scribes called at that time in the third month, that is, the month Sivan, on the three and twentieth day thereof; and it was written according to all that Mordecai commanded unto the Jews, and to the lieutenants, and the deputies and rulers of the provinces which are from India unto Ethiopia, an hundred twenty and seven provinces, unto every province according to the writing thereof, and unto every people after their language, and to the Jews according to their writing, and according to their language.");

        // Core memorization loop
        while (true)
        {
            Console.Clear();
            scripture.Reference.GetDisplayText();
            Console.WriteLine(scripture.GetText());

            Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(4); // Adjust the number of words to hide as needed
        }

        Console.WriteLine("Good job!");
    }
}