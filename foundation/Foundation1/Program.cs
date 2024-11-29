using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video
        var video1 = new Video { Title = "C# Tutorial", Author = "Quelitho Gabriel", Length = 600 };


        // Add comments
        video1.AddComment(new Comment("Mallorie", "Great tutorial!"));
        video1.AddComment(new Comment("Saint Louis", "Very helpful."));
        

        // Add videos to thr list
        var videos = new List<Video> { video1 };

        //videos and comments
        foreach (var video in videos)
        {
            
        }
    }
}
