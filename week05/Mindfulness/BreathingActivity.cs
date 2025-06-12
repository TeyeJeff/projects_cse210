using System;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity is designed to help you relax by guiding you through slow, mindful breathing. Just focus on your breath.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ActivityLength();
        BreathingExercise();
        DisplayEndingMessage();

    }

    private void BreathingExercise()
    {
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Slowly Inhale for 5 Seconds...");
            ShowCountdown(5);
            elapsed += 5;
            if (elapsed >= _duration) break;

            Console.WriteLine("Hold your Breath for 5 Seconds...");
            ShowCountdown(5);
            elapsed += 5;
            if (elapsed >= _duration) break;

            Console.WriteLine("Slowly Exhale for 7 Seconds...");
            ShowCountdown(7);
            elapsed += 7;

        }
    }





}

    







