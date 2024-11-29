using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video { Title = "C# Tutorial", Author = "Quelitho Gabriel", Length = 600 };
        var video2 = new Video { Title = "Cooking Tips", Author = "Mallorie Daelle", Length = 900 };
        var video3 = new Video { Title = "Travel Vlog", Author = "Saint Louis", Length = 1200 };

        // Add comments
        video1.AddComment(new Comment("Dave", "Great tutorial!"));
        video1.AddComment(new Comment("Junior", "Very helpful."));
        video1.AddComment(new Comment("Delva", "Good Job!"));

        video2.AddComment(new Comment("Tilus", "Love this recipe!"));
        video2.AddComment(new Comment("Mathis", "Cannot wait to try this out."));

        video3.AddComment(new Comment("Peter", "Great places!"));
        video3.AddComment(new Comment("John", "Thank you for the tips."));
        video3.AddComment(new Comment("Brutus", "Wow, so beautiful!"));

        // Add videos to a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display videos and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
