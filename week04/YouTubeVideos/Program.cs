using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C#", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "Travel Hub", 900);
        video2.AddComment(new Comment("Emma", "Amazing places!"));
        video2.AddComment(new Comment("Lucas", "I want to visit these."));
        video2.AddComment(new Comment("Sophia", "Beautiful video."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Football Highlights", "Sports Central", 450);
        video3.AddComment(new Comment("Mike", "Awesome match."));
        video3.AddComment(new Comment("David", "Best highlights."));
        video3.AddComment(new Comment("Sarah", "Great editing."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Cooking Pasta", "Chef Maria", 720);
        video4.AddComment(new Comment("Anna", "Looks delicious!"));
        video4.AddComment(new Comment("James", "Trying this tonight."));
        video4.AddComment(new Comment("Olivia", "Easy to follow recipe."));
        videos.Add(video4);

        // Display Videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}