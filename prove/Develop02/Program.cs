using System;
using System.ComponentModel;
using System.Net;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        bool continueMenu = true;

        while (continueMenu)
        {

            Console.WriteLine("Please select from the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Entry entry = new Entry();
                    entry.displayEntry();
                    break;

                case "2":
                    Console.WriteLine("2. Display");

                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":
                    Console.WriteLine("5. Quit");
                    continueMenu = false;
                    break;

            }
        }
    }
}