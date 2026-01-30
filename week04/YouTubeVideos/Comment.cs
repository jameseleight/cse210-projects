using System;
public class Comment
{
    private string _name;
    private string _commentText;
    // Constructors
    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
    }
    public void DisplayAll()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_commentText}");
    }
}