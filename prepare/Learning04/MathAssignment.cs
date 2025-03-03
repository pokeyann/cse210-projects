using System;
using System.Diagnostics.Contracts;

class MathAssignment : Assignment
{
  private string _textBookSection;
  private string _problem;

  /* Not sure why I don't need to use getters and setters for this section?
  public string GetTextBookSection()
  {
    return _textBookSection;
  }

  public void SetTextBookSection(string textBookSection)
  {
    _textBookSection = textBookSection;
  }

  public string GetProblem()
  {
    return _problem;
  }

  public void SetProblem(string problem)
  {
    _problem = problem;
  }*/

  public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
  {
    _textBookSection = textBookSection;
    _problem = problem;
  }

  /* return $"{GetStudentName()} - {GetTopic()}, {GetTextBookSection()}, {GetProblem()}"*/

  public string GetHomeworkList()
  {
    return $"Section {_textBookSection} Problems {_problem}";
  }
}


