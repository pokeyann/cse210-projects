using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
  public Reference ScriptureReference { get; set; }
  private List<Word> Words = new List<Word>();
  private static Random random = new Random();

  public Scripture(Reference reference, string text)
  {
    ScriptureReference = reference;
    Words = text.Split(' ').Select(word => new Word(word)).ToList();
  }

  public void Display()
  {
    Console.Clear();
    Console.WriteLine($"{ScriptureReference}\n");
    Console.WriteLine(string.Join(" ", Words));
  }

  public void HideRandomWords(int count = 2)
  {
    var visibleWords = Words.Where(w => !w.IsHidden).ToList();

    if (visibleWords.Count == 0)
      return;

    int wordsToHide = Math.Min(count, visibleWords.Count);

    for (int i = 0; i < wordsToHide; i++)
    {
      var wordToHide = visibleWords[random.Next(visibleWords.Count)];
      wordToHide.Hide();
      visibleWords.Remove(wordToHide);
    }
  }

  public bool AllWordsHidden()
  {
    return Words.All(w => w.IsHidden);
  }
}