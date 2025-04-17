public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you with your breathing.";
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Clear();
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Thread.Sleep(500);
            ShowCountDownNumber(5);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.Write("Breathe out... ");
            Thread.Sleep(500);
            ShowCountDownNumber(4);
            Console.WriteLine();
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}