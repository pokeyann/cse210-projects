using System;
using System.Collections.Generic;

public class Comment
{
  public string Name { get; set; }
  public string CommentText { get; set; }

  public Comment(string name, string commentText)
  {
    Name = name;
    CommentText = commentText;
  }  

}