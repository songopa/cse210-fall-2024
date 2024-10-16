public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public void AddComment(string name, string comment)
    {
        _comments.Add(new Comment(name, comment));
    }

    public int CommentCount()
    {
        return _comments.Count();
    }

    public void DisplayVideoText()
    {
        Console.WriteLine($"\n{_title} by {_author} - {_seconds/60}:{_seconds%60}");
        Console.WriteLine($"Total comments: {CommentCount()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.DisplayCommentText()}");
        }
    }
}