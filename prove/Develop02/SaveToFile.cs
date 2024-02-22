using System;
using System.Collections.Generic;
using System.IO;

public class SaveToFile
{
  public void saveFile(/*List<string> entry*/)
  {
    Console.WriteLine("testing save to file...");

    List<string> entry = new List<string>();

    string filename = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (string e in entry)
      {
        outputFile.WriteLine(e);
      }
    }

  }
}
