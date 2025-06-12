using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What motivates you?",
        "What something you did in the past motivates other people?",
        "What positive changes have you made in your life?",
        "Who is the most positive influence in your life?",
        "What positive changes are you going to make this week?"
    };

    public ListingActivity() : base(
        "Listing",
        "This is an activity to help you reflect on a list of positive things in your life"
    )
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        ActivityLength();
        string prompt = GetRandomPrompt();
        Console.WriteLine("Respond to the prompt with as many thoughts or answers as you can think of.");
        Console.WriteLine($"This Exercise begins in:");
        Console.WriteLine($"---{prompt}---");
        ShowCountdown(5);
        GetListFromUser();
        DisplayEndingMessage();
    }


    private string GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        return prompt;
    }



    private void GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Please input an item (or press Enter to finish early): ");
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item)) break;
            items.Add(item);
        }


        Console.WriteLine($"\nYou listed {items.Count} items.");       
    }







}