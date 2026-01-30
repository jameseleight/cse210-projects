using System;
public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();
    // Constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthSeconds = length;
    }
    // Methods for Video Class
    public void AddComment(Comment newComment)
    {
        // Add a new comment to the list
        _comments.Add(newComment);
    }    
    public int NumberOfComments()
    {
        // Determine the number of comments set for this video item
        return _comments.Count;
    }
    public void DisplayAll()
    {
        Console.WriteLine();
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length: {_lengthSeconds}");
    }
    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            comment.DisplayAll();
        }
    }
}