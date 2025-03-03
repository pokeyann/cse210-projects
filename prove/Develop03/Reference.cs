using System;

public class Reference
{
  public string Book { get; set; }
  public int Chapter { get; set; }
  public int StartVerse { get; set; }
  public int EndVerse { get; set; }

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

  internal string[] split(char v)
  {
    throw new NotImplementedException();
  }
}