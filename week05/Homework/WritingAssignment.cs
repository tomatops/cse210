public class WritingAssignment : Assignment
{
    private string _title;

    // Sets the member variables
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Gets the title
    public string GetWritingInformation()
    {
        return _title;
    }
}