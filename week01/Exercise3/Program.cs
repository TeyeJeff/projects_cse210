using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int correctNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int counts = 0;
        
        Console.WriteLine("A number has been chosen between 1 and 100. Try to guess it!");
        
        while (guess != correctNumber)
        {
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            if (correctNumber > guess)
            {
                Console.WriteLine("Higher");
                counts +=1;
            }
            else if (correctNumber < guess)
            {
                Console.WriteLine("Lower");
                counts +=1;
            }
            else
            {
                Console.WriteLine("Congratulations, You guessed it!" );
                counts +=1;
                Console.WriteLine($"You had {counts} guesses");        
            }   
            
        }
    }
}