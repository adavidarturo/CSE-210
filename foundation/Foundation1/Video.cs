using System.Collections.Generic;

public class Video
{
    private string _title; // Attribute for the video title
    private string _author; // Attribute for the video author
    private int _duration;// Attribute for the video duration
    private List<Comment> _comments; // Attribute for a list of "comments"

    // Constructor to initialize the video variables
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    // Method to add comments to the "_comments" list 
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to save the list of comments
    private List<Comment> GetComments()
    {
        return _comments;
    }

    // Method to Display all Video information
    public string Display() 
    {
        string displayText = $"Title: {_title}\nAuthor: {_author}\nDuration: {_duration} seconds\nCommets:\n\n";

        foreach (Comment comment in _comments) // For each comment in the _comments list
        {
            displayText += comment.Display() + "\n"; // Display Video and Comments 
        }
        return displayText; // Save final value "displayText"
    }
}


