using System;
public class Word
{
    private string _text;
    private bool _isHidden;
    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;  // note that word text is not hidden by default
    }
    public void Hide()
    {
        // This method is to set that the word is to be hidden.  I.e. to hide the word in the scripture by settign the _isHidden to true.
    }
    public void Show()
    {
        // This method is to set that the word is to be shown.  i.e. to show the word in the scripture by setting the _isHidden to false.
    }
    public bool IsHidden()
    {
        // This method is chech and return the value of _isHidden.  It helps to keep track which words are hidden and which remain shown.
        return false;
    }
    public string GetDisplayText()
    {
        // This method is to generate the dispaly text, either the word characters or underscores in place of the word characters.
        // Need a space before each word whether characers or underscores.
        return "test display";
    }
}