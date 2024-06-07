using System;
using System.Security.Cryptography.X509Certificates;

class Program /*MUST CHANGE GETTER SETTER SITUATION IN SCRIPTURE.CS, ANNOUNCEMENT SAID THAT IS THE WRONG WAY TO DO IT!*/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        /* Shows how Console.Clear should work
                Console.WriteLine("AAA");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("BBB");
         */
        Program program = new Program();
        program.Reference();
        program.UserChoice();
    }

    public void Reference() /*Need variable to deal with multiVerse, so oneVerse and multiVerse aren't showing up at the same time*/
    {
        Scripture oneVerse = new Scripture("Zephaniah", "3", "17", "The Lord thy God in the midst of thee is mighty; he will save, he will rejoice over thee with joy; he will rest in his love, he will joy over thee with singing.");
        Console.WriteLine(oneVerse.GetFullScripture());
        Console.WriteLine();

        Scripture multiVerse = new Scripture("Galations", "5", "22, 25", "22. But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, 25. If we live in the Spirit, let us also walk in the Spirit.");
        Console.WriteLine(multiVerse.GetFullScripture());
        Console.WriteLine();
    }

    public void UserChoice()
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
    }
}


/*
Word keeps track of a single word and whether it is shown or hidden.
Behaviors: Hide, Show, Is Hidden, Get Rendered Text
Variables: 
Constructor: accept text of the word and save as attribute. Set intial visibility of the word (shown or hidden)
*/