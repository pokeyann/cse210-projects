using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        BaseMessage baseMessage = new BaseMessage();

        bool loopContinue = true;
        while (loopContinue)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Breathing breathing = new Breathing();
                    breathing.BreathingActivity();
                    break;
                case 2:
                    Reflection reflection = new Reflection();
                    reflection.ReflectionActivity();
                    break;
                case 3:
                    Listing listing = new Listing();
                    listing.ListingActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}