using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "This is the word of God: Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(scripture1.GetDisplayText() + "\n");

        List<int> availableIndices = Enumerable.Range(0, scripture1.GetWordsLength()).ToList();
        Random random = new Random();

        while (true)
        {
            Console.WriteLine('\n');
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            
            if (scripture1.IsCompletelyHidden() == true)
            {
                break;
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.Clear();
                
                int numToHide = Math.Min(3, availableIndices.Count);
                List<int> selectedIndices = new List<int>();

                
                for (int i = 0; i < numToHide; i++)
                {
                    int pos = random.Next(availableIndices.Count);
                    int index = availableIndices[pos];
                    selectedIndices.Add(index);
                    availableIndices.RemoveAt(pos); 
                }

                
                foreach (int index in selectedIndices)
                {
                    scripture1.HideRandomWords(index);
                }

                Console.WriteLine(scripture1.GetDisplayText());
            }

            
            else if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            
            else
            {
                Console.WriteLine("Sorry, I cannot accept this input at this time");
            }
        }
    }
}