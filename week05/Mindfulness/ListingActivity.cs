public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things you have experienced in your life by having you list as many things as you can from a given prompt.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("List as many answers as you can to the following prompt:");

        Thread.Sleep(2000);
        Console.WriteLine();
        GetRandomPrompt();

        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("You may begin in... ");
        Thread.Sleep(500);
        ShowCountDownNumber(5);

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> _answers = new List<String>();
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _answers.Add(answer);
        }
        
        Console.WriteLine();
        _count = _answers.Count();
        Console.WriteLine($"You listed {_count} items!");
        
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random i = new Random();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        string prompt = _prompts[i.Next(_prompts.Count)];

        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> _answers = new List<String>();
        return _answers;
    }
}