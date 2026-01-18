using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    // Constructor
    public Scripture(Reference reference, string text)
    {
        // This constructor will load the reference and the words of the verse
    }   
    public void HideRandomWords(int numberToHide)
    {
        // This method is to randomly select numberToHide individual words and set the to Hide().  An extension is to hide additional words and not a word that is already hidden.
    }
    public string GetDisplayText()
    {
        // This method is to return the diplay text that includes the reference and the words hidden or shown.
        return "test";
    }
    public bool IsCompletelyHidden()
    {
        // This method is to determine if all the words of the verse are hidden in which case after being displayed, the program will end.
        return false;
    }
}