public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public void Run()
    {
        StartActivity();
        Random rnd = new Random();
        Console.WriteLine("This activity will help you reflect on the good things in your life by listing as many things as you can.");
        StartSpinner(5);
        string prompt = prompts[rnd.Next(prompts.Length)]; // Select a random prompt
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing (enter 'done' when finished):");
        int answerCount = 0; // Counter for tracking the number of answers
        string answer = ""; // Variable to store each answer

        do
        {
            answer = Console.ReadLine();
            if (answer.ToLower() != "done")
            {
                answerCount++;
            }
        } while (answer.ToLower() != "done");

        Console.WriteLine($"You provided {answerCount} answer(s).");

        End("listing");
    }
}




//    {
//         StartActivity();
//         Random rnd = new Random();
//         Console.WriteLine("This activity will help you reflect on the good things in your life by listing as many things as you can.");
//         StartSpinner(5);

//         int answerCount = 0; // Counter for tracking the number of answers

//         while (!AmIDone())
//         {
//             string prompt = prompts[(prompts.Length)];
//             Console.WriteLine(prompt);
//             Console.WriteLine("Start listing (enter 'done' when finished):");

//             string answer = ""; // Variable to store each answer
//             do
//             {
//                 answer = Console.ReadLine();
//                 if (answer.ToLower() != "done")
//                 {
//                     answerCount++;
//                 }
//             } while (answer.ToLower() != "done");

//             Console.WriteLine($"You provided {answerCount} answer(s).");
//         }
//         End("listing");
//     }
// }
//     {
//         StartActivity();
//         Random rnd = new Random();
//         Console.WriteLine("This activity will help you reflect on the good things in your life by listing as many things as you can.");
//         StartSpinner(5);

//         while (!AmIDone())
//         {
//             string prompt = prompts[rnd.Next(prompts.Length)];
//             Console.WriteLine(prompt);
//             Console.WriteLine("Start listing...");
//             Console.ReadLine();
//             Console.WriteLine("End listing...");
//         }
//         End("listing");
//     }
// }

// for (int i = duration; i > 0; i--)
// {
//     string prompt = prompts[rnd.Next(prompts.Length)];
//     Console.WriteLine(prompt);
//     Console.WriteLine($"Start listing... {i}");
//     Thread.Sleep(1000); // Wait for 1 second
//     Console.WriteLine($"End listing... {i}");
// }
// Console readline for response