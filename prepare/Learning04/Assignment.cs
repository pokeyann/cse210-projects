using System;
using System.Runtime.CompilerServices;

class Assignment
{
  private string _studentName;
  private string _topic;

  public Assignment(string studentName, string topic)
  {
    _studentName = studentName;
    _topic = topic;
  }

  public string GetStudentName()
  {
    return _studentName;
  }

  public void SetStudentName(string studentName)
  {
    _studentName = studentName;
  }

  public string GetTopic()
  {
    return _topic;
  }

  public void SetTopic(string topic)
  {
    _topic = topic;
  }

  public string GetSummary()
  {
    /*return _studentName + "-" + _topic; This was how it was on the student sample, sticking with how I did it originally just cause.*/

    return $"{_studentName} - {_topic}"; /*want to try and see if this works once other code is working correctly. */
  }
}
