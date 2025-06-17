using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for participating in this exercises.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press Enter to try again...");
                    Console.ReadLine();
                    continue;
            }

            if (activity is BreathingActivity breathing)
                breathing.Run();
            else if (activity is ListingActivity listing)
                listing.Run();
            else if (activity is ReflectingActivity reflecting)
                reflecting.Run();
        }
    }
}