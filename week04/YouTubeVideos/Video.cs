// Tracks the title, author, and length (in seconds) of the video. Each video also has responsibility to store a list of comments.
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    // Returns number of comments
    public int GetCommentQuantity()
    {
        return _comments.Count;
    }

    // Display details of the video
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentQuantity()}");

        Console.WriteLine("COMMENTS");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine("------------------");
            comment.DisplayComment();
        }
    }
}

