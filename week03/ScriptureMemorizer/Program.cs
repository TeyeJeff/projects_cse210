using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scipture1 = new Scripture(reference1, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(scipture1.GetDisplayText() + "\n");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        List<int> availableIndices = Enumerable.Range(0, scipture1.GetWordsLength() - 1).ToList();
        Random random = new Random();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "quit" || scipture1.IsCompletelyHidden() == false)
            {
                Console.WriteLine("here 1");
                break;
            }
            else if (input.Trim() == "")
            {
                Console.Clear();
                Console.WriteLine("here 2");
                for (int i = 0; i < 3; i++)
                {
                    int index = random.Next(0, scipture1.GetWordsLength());
                    scipture1.HideRandomWords(index);
                    availableIndices.RemoveAt(index);
                }

                Console.WriteLine(scipture1.GetDisplayText());
            }
            else
            {
                Console.WriteLine("Sorry, I cannot accept this input at this time");
                break;
            }     
        }
    }
}