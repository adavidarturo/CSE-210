using System.Collections.Generic;

public class Video
{
    public string Title { get; set; } // Attribute for the video title
    public string Author { get; set; } // Attribute for the video author
    public int Duration { get; set; } // Attribute for the video duration
    private List<Comment> _comments; // Attribute for a list of "comments"

    // Constructor to initialize the video variables
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        _comments = new List<Comment>();
    }

    // Method to add comments to the "_comments" list 
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to count all comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to optain the list of Comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}


