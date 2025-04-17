public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine("====================");
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);

        Console.WriteLine();
        Console.Write("Duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready");
        ShowCountDownDots(2);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Thread.Sleep(500);
        Console.WriteLine("Well done!");

        Thread.Sleep(100);
        ShowSpinner(1);

        Console.WriteLine("--------------------");
        Console.WriteLine($"You have completed the {_name} in {_duration} seconds.");

        Thread.Sleep(100);
        ShowSpinner(1);

        Thread.Sleep(1000);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinAnimation = ["|", "/", "—", "\\"];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            foreach (string s in spinAnimation)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDownNumber(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDownDots(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string d = ".";
            Console.Write(d);
            Thread.Sleep(1000);
            Console.Write(d);
            Thread.Sleep(1000);
            Console.Write(d);
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
        }
    }
}