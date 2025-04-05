using System;

class Program
{
    static void Main(string[] args)
    {
        // Sets the reference and text of the scripture
        Reference reference = new Reference("1 Corinthians", 6, 19, 20);
        Scripture scripture = new Scripture(reference, "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God's.");
        Console.WriteLine(scripture.GetDisplayText());
    }
}