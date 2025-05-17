using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal myJournal = new Journal();

        while (true)
        {
            PromptGenerator promptGenerator = new PromptGenerator();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine().Trim();


            if (input == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string answer = Console.ReadLine();
                string date = DateTime.Today.ToString("MM/dd/yyyy");

                Entry newEntry = new Entry();
                newEntry._answer = answer;
                newEntry._date = date;
                newEntry._prompt = prompt;

                myJournal.AddEntry(newEntry);
            }
            else if (input == "2")
            {
                myJournal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine().Trim();
                myJournal.LoadFromFile(filename);
            }
            else if (input == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine().Trim();
                myJournal.SaveToFile(filename);
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, kindly choose a valid option");
            }
        }
        
    }
}