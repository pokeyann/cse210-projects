using System;
using System.ComponentModel;
using System.Net;
using System.Collections.Generic;
public class LoadFromFile
{
  public void readFile()
  {
    Console.WriteLine("testing read from file...");

    List<string> entry = new List<string>();

    string filename = "journal.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }

    // need to add .Add
    /*return entry;*/
  }
}