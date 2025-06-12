using System;
using System.Collections.Generic;


public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for a loved one.",
        "Think of a time when you did actually had fun.",
        "Think of a time you prayed to God.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you bought something new for yourself",
    };

    private List<string> _questions = new List<string>()
    {
        "How was this experience meaningful to you?",
        "What were your emotions after finishing it?",
        "What insights did you gain about yourself?",
        "How can you apply this in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will guide you in contemplating times of resilience and personal development.")
    {
    }

    public void Run()

    {
        DisplayStartingMessage();
        ActivityLength();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();

    }


    private string GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        return prompt;
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        string questions = _questions[rand.Next(_questions.Count)];
        return questions;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press Enter...");
        Console.ReadLine();
    }


    private void DisplayQuestions()
    {
        Console.WriteLine("Now, ponder each question as it appears.");
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(10); 
            elapsed += 10;
        }
    }













}