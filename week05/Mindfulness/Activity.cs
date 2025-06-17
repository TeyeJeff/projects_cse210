using System;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Hello, Welcome to the {_name} Activity");
        Console.WriteLine($"{_description}");
    }

    protected void ActivityLength()
    {
        Console.Write("\nHow many seconds would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to start...");
        ShowSpinner(5);
    }

    

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n Congrats, Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.WriteLine("Please select Enter to continue... ");
        Console.ReadLine();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i > seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(2000);
            Console.Write("\b \b");
        }
    }






}