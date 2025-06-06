using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Front End Developer";
        job1._companyName = "Activision Blizzard";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Database Administrator";
        job2._companyName = "Guarantee Trust Bank";
        job2._startYear = 2018;
        job2._endYear = 2021;

        Resume resume1 = new Resume();
        resume1._name = "Achia Baffour";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}