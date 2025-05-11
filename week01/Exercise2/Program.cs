using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage in the maths exams? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        string letter = "";
        
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 && number <= 89)
        {
            letter = "B";
        }
        else if (number >= 70 && number <= 79)
        {
            letter = "C";
        }
        else if (number >= 60 && number <=69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >=70)
        {
            Console.WriteLine("Excellent, You passed the exams, keep it up");
        }
        else
        {
             Console.WriteLine("You didnt meet the pass mark, keep working hard and better luck next time");
        }


    }
}