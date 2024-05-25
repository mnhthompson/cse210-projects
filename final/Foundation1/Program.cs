using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
                List<Video> vidList = new List<Video>();

        // Vid 1
        Video vid1 = new Video("Mario 64 Speedrun","Bowser", 450);

        Comment vid1Comment1 = new Comment("Mario", "Mama mia, bowser is scary");

        Comment vid1Comment2 = new Comment("Luigi", "This is Fake");

        Comment vid1Comment3 = new Comment("Peach", "Who wants cake");

        vid1.ListComment(vid1Comment1);
        vid1.ListComment(vid1Comment2);
        vid1.ListComment(vid1Comment3);

        vidList.Add(vid1);

        // Vid 2
        Video vid2 = new Video("12 Life Hacks", "ABCcrafts", 1030);

        Comment vid2Comment1 = new Comment("John", "Tell me this isnt real");

        Comment vid2Comment2 = new Comment("James", "So cursed");

        Comment vid2Comment3 = new Comment("Julia", "The hacks are simply Amazing.");

        vid2.ListComment(vid2Comment1);
        vid2.ListComment(vid2Comment2);
        vid2.ListComment(vid2Comment3);

        vidList.Add(vid2);

        // Vid 3
        Video vid3 = new Video("top 10 Basketball shots", "Sports master 54", 100);

        Comment vid3Comment1 = new Comment("Joe", "Your camera work is apalling");

        Comment vid3Comment2 = new Comment("Jille", "Invest in better shoes man");

        Comment vid3Comment3 = new Comment("James", "Number 1 isn't real");

        vid3.ListComment(vid3Comment1);
        vid3.ListComment(vid3Comment2);
        vid3.ListComment(vid3Comment3);

        vidList.Add(vid3);


    foreach (Video video in vidList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}