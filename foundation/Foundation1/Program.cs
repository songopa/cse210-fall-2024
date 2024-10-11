using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Talk to Jesus", "Maverick City", 572);
        video1.AddComment("Filipo", "waoooh what a wonderfull song");
        video1.AddComment("Aisha", "like here everytime for me to watch");
        video1.AddComment("Misha", "took me deep");

        Video video2 = new Video("Song of Angels", "Judikay", 415);
        video2.AddComment("Saimoni", "Holy Spitit teach me to sing the songs of angels");
        video2.AddComment("Chalito", "Never gets old");
        video2.AddComment("Zebedayo", "evertime I listen I get blessed");

        video1.DisplayVideoText();
        video2.DisplayVideoText();
    }
}