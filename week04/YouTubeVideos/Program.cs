using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        List<Video> videoList = new List<Video>();
        // Load data into list of Video variables (4 videos with 3-4 comments)
        Video video1 = new Video("My dog has fleas", "James Leight", 276);
        Comment comment1a = new Comment("Daniel", "My dog has fleas too...");
        Comment comment1b = new Comment("Mark", "Try a flea collar.");
        Comment comment1c = new Comment("Luke", "How many fleas can a dog get?");
        Comment comment1d = new Comment("John", "This is a boring video.");
        video1.AddComment(comment1a);
        video1.AddComment(comment1b);
        video1.AddComment(comment1c);
        video1.AddComment(comment1d);
        videoList.Add(video1);
        Video video2 = new Video("My cat has fleas", "Jim Leight", 653);
        Comment comment2a = new Comment("Daniel", "My cat has fleas too...");
        Comment comment2b = new Comment("Mark", "Try a flea dip.");
        Comment comment2c = new Comment("Luke", "How many fleas can a cat eat?");
        video2.AddComment(comment2a);
        video2.AddComment(comment2b);
        video2.AddComment(comment2c);
        videoList.Add(video2);
        Video video3 = new Video("My donkey has fleas", "Jimmy Leight", 1096);
        Comment comment3a = new Comment("Daniel", "Your donkey is funny");
        Comment comment3b = new Comment("Mark", "Who has a donkey?");
        Comment comment3c = new Comment("Luke", "Look at those fleas go!");
        Comment comment3d = new Comment("John", "This is a boring video.");
        video3.AddComment(comment3a);
        video3.AddComment(comment3b);
        video3.AddComment(comment3c);
        video3.AddComment(comment3d);   
        videoList.Add(video3);
        Video video4 = new Video("My lizard has fleas", "Jimbo Leight", 5);
        Comment comment4a = new Comment("Daniel", "Your lizzard is beautiful");
        Comment comment4b = new Comment("Mark", "Where are the fleas?");
        Comment comment4c = new Comment("Luke", "Lizzards like to eat fleas.");
        video4.AddComment(comment4a);
        video4.AddComment(comment4b);
        video4.AddComment(comment4c);
        videoList.Add(video4);
        // Provide output
        foreach (var video in videoList)
        {
            video.DisplayAll();
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            video.DisplayComments();
        }
        Console.WriteLine("Thanks for using the YouTube Video Program. Goodbye!");
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the YouTube Video Program!");
    }
}