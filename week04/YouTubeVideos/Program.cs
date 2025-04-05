using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video1", "Diego", 300);
        video1.AddComment("Jorge", "Nice video");
        video1.AddComment("Sonia", "So funny");
        video1.AddComment("Victor", "new sub");
        Video video2 = new Video("Video2", "Sigrid", 400);
        video2.AddComment("Miguel", "Nice video");
        video2.AddComment("John", "So funny");
        video2.AddComment("Marco", "new sub");
        video2.AddComment("Dorian", "new sub");
        Video video3 = new Video("Video3", "Jorge", 500);
        video3.AddComment("Jorge", "Nice video");
        video3.AddComment("Sonia", "So funny");
        video3.AddComment("Victor", "new sub");
        Video video4 = new Video("Video4", "Steves", 600);
        video4.AddComment("Miguel", "Nice video");
        video4.AddComment("John", "So funny");
        video4.AddComment("Marco", "new sub");
        video4.AddComment("Dorian", "new sub");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            Console.WriteLine(video.GetDisplayDataVideo());
        }
    }
}