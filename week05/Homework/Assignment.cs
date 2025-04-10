public class Assignment
{
    protected string _studentName;
    protected string _topic;
    
    // Sets the member variables
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Gets the student name and topic in one string
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}