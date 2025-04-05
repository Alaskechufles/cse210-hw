public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;

    }

    public void AddComment(string nameCommenter, string comment)
    {
        Comment newComment = new Comment(nameCommenter, comment);
        _comments.Add(newComment);

    }
    public string GetDisplayDataVideo()
    {
        return $"Title: {_title} | Author: {_author} \nLength in seconds: {_lengthInSeconds} | Comments: {_comments.Count} \n -----";
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
}