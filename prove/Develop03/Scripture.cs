using System;

class Scripture
{
  
  
  List<Reference> references = new List<Reference>();

  public void AddScripture(string book, int chapter, int startVerse, int endVerse)
  {
    Reference newReference = new Reference(book, chapter, startVerse, endVerse);
    references.Add(newReference);
  }

  public void DisplayScripture()
  {
    foreach (Reference reference in references)
    {
      Console.WriteLine(reference);
      
    }
  }
}