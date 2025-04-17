public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on the experiences in your life and how you showed strength and perseverance during those times.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine();
        Thread.Sleep(500);
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, ponder on the following questions related to this experience.");
        Thread.Sleep(1000);
        Console.WriteLine("You may begin in... ");
        ShowCountDownNumber(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            int time = _duration / 2;
            DisplayQuestions();
            ShowSpinner(time);
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(time);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random i = new Random();

        _prompts.Add("Think of a time you wanted to quit something but didn’t.");
        _prompts.Add("Think of a moment where you stood up for yourself or for someone else even when it was hard.");
        _prompts.Add("Think of a time when you felt completely alone.");
        _prompts.Add("Think about a hard decision you had to make.");
        _prompts.Add("Think about something you once thought you could never do but still did it anyway.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        string prompt = _prompts[i.Next(_prompts.Count)];

        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random i = new Random();

        _questions.Add("How did that experience make you feel?");
        _questions.Add("What did you to overcome your struggles during the time?");
        _questions.Add("What did you feel when it was over?");
        _questions.Add("What is your favorite thing from the experience?");
        _questions.Add("What lessons have you learned from that moment?");
        _questions.Add("How did you get started?");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What could you learn from this experience that applies to other situations?");

        string question = _questions[i.Next(_questions.Count)];

        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}