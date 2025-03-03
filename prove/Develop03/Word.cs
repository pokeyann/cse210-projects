using System;
using System.Collections.Concurrent;

public class Word
{
  public string Text { get; private set; } /* Could write a separate line for public get and private set, but this seems to work as well*/
  public bool IsHidden { get; private set; }

  public Word(string text)
  {
    Text = text;
    IsHidden = false;
  }

  public void Hide()
  {
    IsHidden = true;
    Text = "_";
  }

  public override string ToString()
  {
    return IsHidden ? "_____" : Text;
  }
}