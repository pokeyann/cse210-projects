using System;

class Listing : BaseMessage
{
  public void ListingActivity()
  {
    StartMessage("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");

    Console.WriteLine("List as many responses you can to the following prompt: ");
    Console.WriteLine();
    Thread.Sleep(500);

    string listPrompt = PromptList();
    Console.WriteLine(listPrompt);
    CountdownAnimation();

    static string PromptList()
    {
      List<string> promptList = new List<string>
            {
             "Who are people you appreciate? ",
             "What are your strengths? ",
             "Who have you helped this week? ",
             "When have you felt the Holy Ghost this month? ",
             "Who are your heroes? "
            };

      Random statementList = new Random();

      int index = statementList.Next(promptList.Count);

      return promptList[index];
    }

   

    List<string> userEntry = new List<string>();
    
    DateTime endTime = DateTime.Now.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
    Console.Write("> ");
    string input = Console.ReadLine(); 
    if (!string.IsNullOrEmpty(input))
    {
    userEntry.Add(input);
    }
    }
    Console.WriteLine($"You listed {userEntry.Count} items.");
    

  EndMessage("Listing Activity");

  }
}