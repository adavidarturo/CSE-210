public class Word
{
    // Declare 2 characteristics
    private string _text; // To storage text
    private bool _isHidden; // To decide if it is hidden or not 

    // Constructor to initialize characteristics 
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Default False value
    }

    // Method to Hide word
    public void Hide() 
    {
        _isHidden = true;
    }

    // Method to Show word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to storage the decision 
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    // Method to Get the final Display in _text and "_"
    public string GetDisplayText()
    {
        if (IsHidden()) // If IsHidden()
        {
            // Save a new instance from the _text length in "_"
            return new string('_', _text.Length); 
        }
        else
        {
            // Save only the _text
            return _text; 
        }
    }
}