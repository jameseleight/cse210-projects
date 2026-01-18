using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; // if there are not multiple verses set this to a null default value so it can be checked and not displayed.
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse; 
    }
    public string GetDisplayText()
    {
        // This method is to generate the dispaly text which is the book followed by space, the chapter followed by :,
        //  the verse (space is before first word). and if there is an end verse the end verse value preceeded by a -.
        return "test display";
    }
}