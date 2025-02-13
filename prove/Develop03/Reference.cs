using System;

class Reference
{
  string Book { get; set; }
  int Chapter { get; set; }
  int StartVerse { get; set; }
  int EndVerse { get; set; }

  public Reference(string book, int chapter, int startVerse, int endVerse)
  {
    Book = book;
    Chapter = chapter;
    StartVerse = startVerse;
    EndVerse = endVerse;
  }

  public override string ToString()
  {
    return $"{Book} {Chapter}: {StartVerse}-{EndVerse}";
  }
}