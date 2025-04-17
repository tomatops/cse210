// For showing creativity and exceeding requirements, I added a menu function that allows the user to return to the previous screen/go back to menu.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}