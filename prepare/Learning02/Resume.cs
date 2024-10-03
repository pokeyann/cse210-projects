using System;

public class Resume
{
  public string _firstName = "";
  public string _lastName = "";
  public List<Job> _jobList = new List<Job>();

  public void DisplayResume()
  {
    Console.WriteLine($"Name: {_firstName} {_lastName}");
    Console.WriteLine("Jobs:");

    foreach (Job job in _jobList)
    {
      job.DisplayJob();
    }
  }
}