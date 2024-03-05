using System.Security.Cryptography.X509Certificates;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public void Run()
    {
        StartActivity();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        StartSpinner(3);
        Random rnd = new Random();

        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.Write("Prompt:");
        Console.WriteLine(prompt);
        Console.ReadLine();

        // Do breathing stuff
        StartActivity();
        while (!AmIDone())
        {
            Console.WriteLine("\nQuestions:");
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.ReadLine();
            }
        }
        End("reflection");
    }
}
// Find a way to loop through this later and grab a new question.
//   StartActivity();
//         int questionsAnswered = 0;
//         while (questionsAnswered < questions.Length)
//         {
//             Console.WriteLine("\nQuestions:");
//             foreach (string question in questions)
//             {
//                 Console.WriteLine(question);
//                 StartSpinner(5);
//                 Console.ReadLine();
//                 questionsAnswered++;
//             }
//         }

//         End("reflection");