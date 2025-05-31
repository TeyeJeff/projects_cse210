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
            // Check if the enter key was pressed (empty or whitespace input)
            if (scripture1.IsCompletelyHidden() == true)
            {
                break;
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.Clear();
                // Determine how many words to hide (3 or remaining count if less than 3)
                int numToHide = Math.Min(3, availableIndices.Count);
                List<int> selectedIndices = new List<int>();

                // Select unique random indices
                for (int i = 0; i < numToHide; i++)
                {
                    int pos = random.Next(availableIndices.Count);
                    int index = availableIndices[pos];
                    selectedIndices.Add(index);
                    availableIndices.RemoveAt(pos); // Remove immediately to avoid duplicates
                }

                // Hide the selected words
                foreach (int index in selectedIndices)
                {
                    scripture1.HideRandomWords(index);
                }

                Console.WriteLine(scripture1.GetDisplayText());
            }

            // Check if the input is "quit" (case-insensitive, ignoring extra spaces)
            else if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Handle any other input
            else
            {
                Console.WriteLine("Sorry, I cannot accept this input at this time");
            }
        }
    }
}