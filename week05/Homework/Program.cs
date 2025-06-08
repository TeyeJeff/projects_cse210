using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Teye Jeff", "Inheritance");
        string assignmentSummary = assignment.GetSummary();
        System.Console.WriteLine(assignmentSummary);

        MathAssignment assignment2 = new MathAssignment("Joana Teye", "Inheritance", "1.6", "25-52");
        string assignmentProblems = assignment2.GetHomeWorkList();
        System.Console.WriteLine(assignmentProblems);

        WritingAssignment assignment3 = new WritingAssignment("Emmanuel Blankson", "African History", "The Journey to Ghana's Independence");
        string assignmentTopic = assignment3.GetWritingInformation();
        System.Console.WriteLine(assignmentTopic);


    }
}