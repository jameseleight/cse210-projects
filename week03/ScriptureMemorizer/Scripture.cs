using System;
using System.Text;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    // Constructor
    public Scripture(Reference reference, string text)
    {
        // This constructor will load the reference and the words of the verse
        _reference = reference;
        string [] splitWords = text.Split(" ");
        foreach (var item in splitWords)
        {
            Word wordItem = new Word(item);
            _words.Add(wordItem);
        }
    }   
    public void HideRandomWords(int numberToHide)
    {
        
        for (int i = 0; i < numberToHide; i++) // Hide a randomly selected word from among those still shown and repeat numberToHide times.
        {
            // Determine number of words that are still shown in the verse and the index for each remaining shown number
            int listIndex = 0;
            List<int> shownWordIndicies = new List<int>();
            foreach (var item in _words)
            {
                if (item.IsHidden() == false)
                {
                    shownWordIndicies.Add(listIndex);
                }
                listIndex++;
            }
            int numWordShown = shownWordIndicies.Count;
            if (numWordShown != 0) // If numWordShown becomes 0, then the number of remaining shown words was less than numberToHide so then skip these lines
            {
                // Select an integer in the range of the length of the shownWordIndicies list.
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(0,numWordShown);
                // The random number is the index in the list of indicies for the shown words.
                // determine the index of the word to Hide
                int wordIndexToHide = shownWordIndicies[randomNumber];
                // Hide the word corresponding to the randomly selected value of the indicies of the remaining words.
                _words[wordIndexToHide].Hide();
                // Repeat for the number of words to Hide.
            }
        }
        // This method is to randomly select a word to hide among the remaining shown words.
    }
    public string GetDisplayText()
    {
        // This method is to return the diplay text that includes the reference and the words hidden or shown.
        var displayText = new StringBuilder();
        displayText.Append(_reference.GetDisplayText());
        foreach (Word item in _words)
        {
            displayText.Append(" " + item.GetDisplayText());
        }
        return displayText.ToString();
    }
    public bool IsCompletelyHidden()
    {
        // This method is to determine if all the words of the verse are hidden in which case after being displayed, the program will end.
        // Start with case that all words are hidden by setting return variable to true.
        bool allHidden = true;
        foreach (var item in _words)
        {
            if (item.IsHidden() == false)
            {
                // If any one or more of the words is shown, then this will change the return variable to false.  Only one is needed
                allHidden = false;
            }
        }
        return allHidden;
    }
}