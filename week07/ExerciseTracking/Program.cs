using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>
        {
            new Running(new DateTime(2025, 06, 19), 82, 5.0), 
            new Cycling(new DateTime(2025, 06, 19), 75, 27.0), 
            new Swimming(new DateTime(2025, 06, 19), 62, 52) 
        };

        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
            Console.WriteLine();
        }
    }
}