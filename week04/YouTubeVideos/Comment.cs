public class Comment
{
    public string _name;
    public string _text;

    // Display details of the comment
    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Text: {_text}");
    }

}