public class Reference
{
    // Declare 4 characteristics
    private string _book; // To storage the _book name
    private int _chapter; // To storage the _chapter 
    private int _verse; // To storage the _verse
    private int? _endVerse; // To storage the final verse

    // Constructor to initialize variables
    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse; // Star of the verse
        _endVerse = endVerse; // End of the verse 
    }

    // Method to Display the References
    public string GetDisplayText()
    {
        if (_endVerse.HasValue) // If _endVerse is equal to -1
        {
            return $"{_book} {_chapter}:{_verse}"; // Save book, chapter and verse
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // Else save also an endVerse
        }
    }
}

