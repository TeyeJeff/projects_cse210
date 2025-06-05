using System;

class Program
{
    static void Main(string[] args)
    {
        // Created a list to store all videos
        List<Video> videos = new List<Video>();

        // Creating video1
        Video video1 = new Video("C# Tutorial for Beginners", "TutorialsPoint", 13620);
        video1.AddComment("joaogabrielv.m328", "Thanks a lot sir, Really helped");
        video1.AddComment("11mamtakumariamathematics68", "Nice Sir");
        video1.AddComment("felix85", "Great tuturials");
        videos.Add(video1);

        // creating video2
        Video video2 = new Video("Indiana Pacers Vs New York Nicks Highlight", "GAMETIME HIGHLIGHT", 583);
        video2.AddComment("RileyFreemanJP", "Siakam played amazing all series, well deserved ECF MVP");
        video2.AddComment("youbuncon247", "Congratulation Indiana on making the NBA finals, that was an entertaining series");
        video2.AddComment("fellastout", "Celtics fan here, I will be sleeping comfortably tonight. What a fun series");
        video2.AddComment("Sam-by8ni", "The Indiana ball flow is too smooth, pleasing to the eye");
        videos.Add(video2);

        // creating video3
        Video video3 = new Video("The Complete Web Development Roadmap", "Programing with Mosh", 915);
        video3.AddComment("NoelEruotor", "I always wanted you to make this video thank you moshh");
        video3.AddComment("HaryyHill-c4e", "An incredibly helpful and comprehensive roadmap for aspiring web developers!");
        video3.AddComment("NoahHarris-e6q", "Wow, this explained everything I was strugging with");
        video3.AddComment("the-developer-channel", "Nice video by the way, very useful");
        videos.Add(video3);


        foreach (Video video in videos)
        {
            Console.WriteLine($"\nVideo Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentsCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment._commentersName}: {comment._commentText}");
            }

        }

    }
}