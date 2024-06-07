using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Console.WriteLine("AAA");
        Console.ReadLine();

        Console.Clear();

        Console.WriteLine("BBB");

    }
    public class Scripture
    {
        private string verse;
        private string multiVerse;
        private string reference;
        private string multiReference;

        /*Scripture keeps track of the reference and text of the scripture. Can hide words and get rendered display of text
        behaviors: Hide Words, Get Rendered Text, Is Completely Hidden
        Variables: reference, all the words in the scripture
        Constructor: accept both reference and text of scripture. pass text of scripture as one string with all words, then constructor
        creating list, splitting  up the words in the string to create Word objects for each one and put them in a list*/
        public Scripture(string verseOne, string verseMulti)
        {
            Verse = verseOne;
            multiVerse = verseMulti;

            verseOne = "The Lord thy God in the midst of thee is mighty; he will save, he will rejoice over thee with joy; he will rest in his love, he will joy over thee with singing.";

            verseMulti = "22. But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, 25. If we live in the Spirit, let us also walk in the Spirit.";
        }

        public string Verse
        {
            get { return verse; }
            set { verse = value; }
        }
        /*Reference keeps track of the book, chapter, and verse information
        Behaviors:
        Variables: book, chapter, verse, second end verse to handle 
        Constructors for single verse and multiverse */
        public void ScriptureReference(string scripRef, string multiRef)
        {
            Reference = scripRef;
            scripRef = "Zephaniah 3:17";
            multiReference = multiRef;
            multiRef = "Galatians 5: 22, 25";
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string GetScripRef()
        {
            string fullScripRef = $"{reference} {verse}";
            return fullScripRef;
        }

        /*Word keeps track of a single word and whether it is shown or hidden.
        Behaviors: Hide, Show, Is Hidden, Get Rendered Text
        Variables: 
        Constructor: accept text of the word and save as attribute. Set intial visibility of the word (shown or hidden)*/
        public void Word(string verse, string multiVerse, string reference, string multiReference)
        {

        }
    }
}