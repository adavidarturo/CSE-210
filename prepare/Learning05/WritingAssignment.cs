
using System.Net;

public class WritingAssignment : Assignment
{
    private string _title;
    private string _author; // Add the Author of the book could be better :)

    public WritingAssignment(string studentName, string topic, string title, string author) : base(studentName, topic)
    {
        _title = title;
        _author = author;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_author}";
    }
}