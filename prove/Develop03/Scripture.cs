

/*Scripture keeps track of the reference and text of the scripture. 
Can hide words and get rendered display of text
behaviors: Hide Words, Get Rendered Text , Is Completely Hidden
Variables: reference, all the words in the scripture
Constructor: accept both reference and text of scripture. 
pass text of scripture as one string with all words, 
then constructor creating list, 
splitting  up the words in the string to create Word objects for each one and put them in a list*/
class Scripture
{
  private string book;
  private string chapter;
  private string verse;
  private string text;

  public Scripture(string aBook, string aChapter, string aVerse, string aText)
  {
    book = aBook;
    chapter = aChapter;
    verse = aVerse;
    text = aText;
  }

  public string GetBook()
  {
    return book;
  }

  public void SetBook(string aBook)
  {
    book = aBook;
  }

  public string GetChapter()
  {
    return chapter;
  }

  public void SetChapter(string aChapter)
  {
    chapter = aChapter;
  }

  public string GetVerse()
  {
    return verse;
  }

  public void SetVerse(string aVerse)
  {
    verse = aVerse;
  }
  public string GetText()
  {
    return text;
  }

  public void SetText(string aText)
  {
    text = aText;
  }

  public string GetFullScripture()
  {
    string fullScripture = $"{book} {chapter}:{verse} {text}";
    return fullScripture;
  }

  public string GetMultiScripture()
  {
    string multiScripture = $"{book} {chapter}:{verse} {text}";
    return multiScripture;
  }
}