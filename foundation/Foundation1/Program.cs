using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Talk to Jesus", "Maverick City", 572);
        video1.AddComment("Filipo", "waoooh what a wonderfull song");
        video1.AddComment("Aisha", "like here everytime for me to watch");
        video1.AddComment("Misha", "took me deep");

        Video video2 = new Video("Song of Angels", "Judikay", 415);
        video2.AddComment("Saimoni", "Holy Spitit teach me to sing the songs of angels");
        video2.AddComment("Chalito", "Never gets old");
        video2.AddComment("Zebedayo", "everytime I listen I get blessed");

        Video video3 = new Video("Oceans", "Hillsong United", 512);
        video3.AddComment("Viktor", "Jesus lead me");
        video3.AddComment("Sundar", "Holy Ghost overflow");
        video3.AddComment("Silvani", "Amaziiiiiiing");
        video3.AddComment("John", "This song helped me through tough times");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoText();
        }
    }
}