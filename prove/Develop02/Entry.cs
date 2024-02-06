namespace dev02;

public class Entry
{
    public string response;
    public string prompt;
    public string date;

    public Entry(string response, string prompt, string date) 
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public Entry(string import)   
    { //import == "What did you do today?|I went to school|2/5/24"
        var parts = import.Split("|");
        this.response = parts[0];
        this.prompt = parts[1];
        this.date = parts[2];
    }
    
    public string Export()
    {
        return $"{response}|{prompt}|{date}";
    }

    public string DisplayString()
    {
        return $"{response} {prompt} {date}";
    }

    static public string GetPrompt()
    {

        // Get a randomized list of entries
        var prompts = new List<string>() {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? "
        };

        // generate a random number 0 ... prompts.Count
        // Generate a random index within the bounds of the prompts list
        Random random = new Random(); // Create a Random object for generating numbers
        int randomIndex = random.Next(prompts.Count); // Get a random index between 0 and prompts.Count-1

        // Retrieve the prompt at the randomly generated index
        string prompt = prompts[randomIndex];

        return prompt; // Return the selected prompt

        //int randomNumber = 1;

        //var prompt = prompts[randomNumber];

        //return prompt;
    }
}