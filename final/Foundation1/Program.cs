using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create comments for the first video
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(new Comment("This video is great"));
        comments1.Add(new Comment("I disagree"));

        Video video1 = new Video();
        video1.InitializeVideo("Gillatte Lecture", "Professor Mitchell", comments1, 60);
        videos.Add(video1);

        // Create comments for the second video
        List<Comment> comments2 = new List<Comment>();
        comments2.Add(new Comment("Awesome content!"));
        comments2.Add(new Comment("Could be better."));

        Video video2 = new Video();
        video2.InitializeVideo("Introduction to Physics", "Dr. Smith", comments2, 45);
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine(); // Add a blank line between videos
        }
    }
}