using System;
using System.Collections.Generic;

public class Program
{
  public static void Main(string[] args)
  {
    var video1 = new Video("How To Make A Money Lei", "Boba Ganoosh", 680);
    var video2 = new Video("How To Convince Your Kid Slime is Evil","Silly Goose", 1360);
    var video3 = new Video("Four High School Graduations In Four Years", "Hokey Pokey", 1976);

    video1.AddComment(new Comment("TooBroke", "Great idea, but who has that much spare money 'leing' around?"));
    video1.AddComment(new Comment("CraftyQueen", "Love it!  Making one for all my nieces and nephews."));
    video1.AddComment(new Comment("CorporateBank", "Super, let us 'lei' a low rate loan on you."));

    video2.AddComment(new Comment("SlimeKid", "NOOOOOOOOOOOOOOOO!  My mom watches this channel."));
    video2.AddComment(new Comment("Momof4", "Thank you! Thank you! Thank you!"));
    video2.AddComment(new Comment("CoolDad", "Too late, it's already smashed all over the carpet."));


    video3.AddComment(new Comment("Memawof4", "Those are my grandbabies!"));
    video3.AddComment(new Comment("SHS24Forever", "I'm there too!  18th row, 6 seats in, do you see me? Roll Tide!"));
    video3.AddComment(new Comment("TooMuch", "I'm tired just watching this.  Better you than me, mama!"));

    List<Video> videos = new List<Video> { video1, video2, video3 };

    foreach (var video in videos)
    {
      video.Display();
    }
  }
}