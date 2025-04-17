public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
    }

    public string GetSummary()
    {
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
}