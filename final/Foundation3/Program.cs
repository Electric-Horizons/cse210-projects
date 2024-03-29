using System;

class Program
{
    static void Main(string[] args)
    {
        // Create events of each type
        LectureEvent lecture = new LectureEvent("AI in Healthcare", "Exploring the impact of AI in the healthcare industry", new DateTime(2024, 4, 15, 10, 0, 0), "123 Main St", "Dr. Emily Smith", 50);
        ReceptionEvent reception = new ReceptionEvent("Networking Mixer", "A networking event for professionals", new DateTime(2024, 4, 20, 18, 0, 0), "456 Elm St", "example@example.com");
        OutdoorEvent outdoor = new OutdoorEvent("Summer Picnic", "Enjoy a day out in the sun with food and games", new DateTime(2024, 5, 1, 12, 0, 0), "789 Oak St", "Sunny");

        while (true)
        {
            Console.WriteLine("\nChoose an event type to display:");
            Console.WriteLine("1. Lecture Event");
            Console.WriteLine("2. Reception Event");
            Console.WriteLine("3. Outdoor Event");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayMenu(lecture);
                    break;
                case "2":
                    DisplayMenu(reception);
                    break;
                case "3":
                    DisplayMenu(outdoor);
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    static void DisplayMenu(Event eventItem)
    {
        Console.WriteLine("\nChoose the type of marketing message to display:");
        Console.WriteLine("1. Full Details");
        Console.WriteLine("2. Standard Details");
        Console.WriteLine("3. Short Description");
        Console.WriteLine("4. Back to main menu");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine(eventItem.GetFullDetails());
                break;
            case "2":
                Console.WriteLine(eventItem.GetStandardDetails());
                break;
            case "3":
                Console.WriteLine(eventItem.GetShortDescription());
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;
        }
    }
}