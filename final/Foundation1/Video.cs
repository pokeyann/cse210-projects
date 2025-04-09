using System;
using System.Collections.Generic;

public class Video
{
  public string Title { get; set; } 
  public string Author { get; set; }
  public int Length { get; set;}
  private List<Comment> Comments { get; set; }
  
  public Video(string title, string author, int length)
  {
    Title = title;
    Author = author;
    Length = length;
    Comments = new List<Comment>();
  }
  
  public void AddComment(Comment comment)
  {
    Comments.Add(comment);
  }

  public int CountComments()
  {
    return Comments.Count;
  }

  public List<Comment> AllComments()
  {
    return Comments;
  }

  public void Display()
  {
      Console.WriteLine($"Title: {Title}");
      Console.WriteLine($"Author: {Author}");
      Console.WriteLine($"Length: {Length} seconds");
      Console.WriteLine($"Number of comments: {CountComments()}");

      Console.WriteLine("Comments:");
      foreach(var comment in Comments)
      {
        Console.WriteLine($"{comment.Name}: {comment.CommentText}");
      }

      Console.WriteLine("");
  }

}