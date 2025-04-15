public class WritingAssignment : Assignment
{
    private string _title;


    public WritingAssignment()
    {
        _title = "Undefined";

    }
    public WritingAssignment(string title)
    {
        _title = title;

    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }

}