// For showing creativity and exceeding requirements, I added another animation that is used by all activities. During the starting message at the "Get Ready..." part, the dots are animated as if it was loading.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        int choice = 0;

        Activity activity = new Activity();

        while (choice != 4)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            choice = int.Parse(Console.ReadLine());

            // 1. Runs the breathing activity
            if (choice == 1)
            {
                BreathingActivity breathingAct = new BreathingActivity();
                breathingAct.Run();
            }

            // 2. Runs the reflecting activity
            else if (choice == 2)
            {
                ReflectingActivity reflectingAct = new ReflectingActivity();
                reflectingAct.Run(); 
            }

            // 3. Runs the listing activity
            else if (choice == 3)
            {
                ListingActivity listingAct = new ListingActivity();
                listingAct.Run();
            }

            // 4. Quits the program
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program.");
            }

            else
            {
                Console.WriteLine("====================");
                Console.WriteLine("Please choose a valid action.");
            }
        }
    }
}