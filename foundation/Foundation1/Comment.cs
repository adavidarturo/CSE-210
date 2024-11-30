public class Comment
{
    public string Name { get; set; } // Attribute for the person's name
    public string Text { get; set; } // Attribute for the comments

    // Constructor to initialize the Comment variables
    public Comment(string name, string text) 
    {
        Name = name;
        Text = text;
    }
}


