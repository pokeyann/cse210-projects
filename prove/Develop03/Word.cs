using System;
using System.Collections.Concurrent;

public class Word
{
  string book = "Proverbs";
  int chapter = 3;
  int startVerse = 5;
  int endVerse = 6;
  /*string words = "Trust in the Lord with all thine heart and lean not unto thine own understanding';' in all the ways acknowledge him',' and he shall direct thy paths'.'";*/

  public void AllTheWords()
  {
    List<string> eachWord = new List<string> { "Trust", "in", "the", "Lord", "with", "all", "thine", "heart", "and", "lean", "not", "unto", "thine", "own", "understanding';'", "in", "all", "the", "ways", "acknowledge", "him','", "and", "he", "shall", "direct", "thy", "paths'.'" };

    foreach (string word in eachWord)
    {
      Console.WriteLine(word);
    }
}
}

/*
book = Proverbs
chapter = 3
startVerse = 5
endVerse = 6
words = Trust in the Lord with all thine heart and lean not unto thine own understanding;
in all the ways acknowledge him, and he shall direct they paths.

loop through and console clear until no all words console cleared or type quit

Scripture scripture = new Scripture();

        bool loopContinue = true;
        while (loopContinue)
        {
            Console.WriteLine(""); book chapter startverse endverse text
            console clear 
            should this be in word and called here?  should the loop be in word?*/
