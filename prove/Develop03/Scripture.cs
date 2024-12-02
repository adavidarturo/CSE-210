using System.Runtime.ConstrainedExecution;

public class Scripture
{
    // Declare 2 characteristics
    private Reference _reference; // To storage the Reference
    private List<Word> _words; // To storage in a list of Word objects

    // Constructor to initialize characteristics and divide the _words list
    public Scripture(Reference reference, string text)
    {
        _reference = reference; // Assign _reference
        _words = new List<Word>(); // Assign a new list _words 

        string[] words = text.Split(" "); // Divide the array "words" with the text(" ") parameter

        foreach (string word in words) // For each index in words list
        {
            _words.Add(new Word(word)); // Add a new Word object
        }
    }

    // Method to hide a random ammount of words 
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random(); // Create a random instance
        int hiddenCount = 0; // Register the hidden amount of words

        while (hiddenCount < numberToHide) 
        {
            // The "index" gets a random number within the range of the _words count
            int index = random.Next(_words.Count); 

            // If the word at the index in the _words list is Not hiddent 
            if (!_words[index].IsHidden())
            {
                _words[index].Hide(); // Then hide the word at that index in the _words list 
                hiddenCount++; // Increment the hiddenCount 
            }
        }
    }

    // Method to display the scripture Reference and the "_" strings
    public string GetDisplayText()
    {
        // Call the GetDisplayText() method from the Reference class plus " -> "
        string text = _reference.GetDisplayText() + " -> "; 

        foreach (Word word in _words) // For each index in the _words list 
        {
            text += word.GetDisplayText() + " "; // Accumulate each word's display text with a " "
        }

        return text; // Storage the final result
    }

    // Method to verify if all words are hidden or not 
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words) // For each index in the _words list 
        {
            if (!word.IsHidden()) // If word is Not hidden 
            {
                return false; // Save a false value
            }
        }
        return true; // Save a true value 
    }
}