using System;
using System.IO;

class Program
{

    static void Main()
    {
        Journal journal = new Journal();

        bool loopContinue = true;
        while (loopContinue)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Dispay");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    string randomPrompt = PromptQuestion();
                    Console.WriteLine(randomPrompt);
                    Console.WriteLine(">");
                    string userEntry = Console.ReadLine();
                    journal.AddEntry(randomPrompt, userEntry, DateTime.Now);
                    break;

                case 2:
                    journal.WriteEntryDisplay();
                    break;

                case 3:

                    Console.WriteLine("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case 4:
                    Console.WriteLine("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case 5:
                    Journal q = new Journal();
                    q.Quit();
                    break;
            }
        }

        static string PromptQuestion()
        {
            List<string> prompt = new List<string>
            {
             "What is your earliest memory? ",
             "Choose between Marvel or DC, and explain why. ",
             "Describe your experiences today? ",
             "Who is your favorite child? ",
             "What is your biggest regret? "
            };

            Random question = new Random();

            int index = question.Next(prompt.Count);

            return prompt[index];
        }
    }
}
