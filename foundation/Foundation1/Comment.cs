public class Comment
{
    private string _name; // Attribute for the person's name
    private string _text; // Attribute for the comments

    // Constructor to initialize the Comment variables
    public Comment(string name, string text) 
    {
        _name = name;
        _text = text;
    }

    // Method to Display both variables
    public string Display()
    {
        return $"{_name}: {_text}";
    }
}


