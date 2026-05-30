using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Introduction to C#",
            "John Smith",
            600);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful video."));
        video1.AddComment(new Comment("Carlos", "Thanks for sharing."));
        video1.AddComment(new Comment("Diana", "Easy to understand."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Object-Oriented Programming",
            "Mary Johnson",
            750);

        video2.AddComment(new Comment("Emma", "Excellent content."));
        video2.AddComment(new Comment("Frank", "I learned a lot."));
        video2.AddComment(new Comment("Grace", "Can you make part 2?"));
        video2.AddComment(new Comment("Henry", "Very clear examples."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Data Structures Basics",
            "Robert Brown",
            900);

        video3.AddComment(new Comment("Isabel", "Awesome tutorial."));
        video3.AddComment(new Comment("Jack", "This helped me study."));
        video3.AddComment(new Comment("Kevin", "Well organized lesson."));
        video3.AddComment(new Comment("Laura", "Thank you!"));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Learning Abstraction",
            "Sarah Wilson",
            500);

        video4.AddComment(new Comment("Mike", "Good examples."));
        video4.AddComment(new Comment("Nina", "Very informative."));
        video4.AddComment(new Comment("Oscar", "Now I understand abstraction."));
        video4.AddComment(new Comment("Paula", "Great job!"));

        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}