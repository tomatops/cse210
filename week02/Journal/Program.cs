using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int choice = 0;

        Journal journal = new Journal();

        while (choice != 5)
        {
            Console.WriteLine("====================");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            choice = int.Parse(Console.ReadLine());

            // 1. Shows the user a random prompt from a list, and save their response, the prompt, and the date as an Entry.
            if (choice == 1)
            {
                Entry writeEntry = new Entry();
                
                // Generates a prompt
                PromptGenerator prompts = new PromptGenerator();
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine("====================");
                Console.WriteLine(prompt);

                writeEntry._promptText = prompt;

                // Gets the date when the entry was created
                DateTime CurrentTime = DateTime.Now;
                writeEntry._date = CurrentTime.ToShortDateString();

                // Get user input for entry text
                Console.Write("");
                writeEntry._entryText = Console.ReadLine();

                // Calls the method to store entry in a list
                journal.AddEntry(writeEntry);
            }

            // 2. Iterates through all entries in the journal and display them to the screen.
            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            // 3. Loads the journal from a file by prompting the user for a filename and then load the journal from that file.
            else if (choice == 3)
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);

            }

            // 4. Saves the journal to a file by prompting the user for a filename and then saving the current journal to that file location.
            else if (choice == 4)
            {
                Console.Write("What do you want to name your file? ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Journal Program.");
            }

            else
            {
                Console.WriteLine("====================");
                Console.WriteLine("Please choose a valid action.");
            }
        }
    }
}