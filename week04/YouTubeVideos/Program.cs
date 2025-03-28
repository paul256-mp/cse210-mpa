using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;


class Video
{
    public List<string> Comments  = new List<string>();
}

class Program
{
    static void Main(string[] args)
    {
        // creating videos
        Video v1 = new Video();
        Video v2 = new Video();
        Video v3 = new Video();

        // adding comments

        foreach (string comment in v1.Comments)
        v1.Comments.Add("video : cse210");
        v1.Comments.Add("length: 4:00");
        v1.Comments.Add("name: julian timber");
        v1.Comments.Add("Great video!");

        v2.Comments.Add("abstraction");
        v2.Comments.Add("length: 3:00");
        v2.Comments.Add("name: paul");
        v2.Comments.Add("good");
            


            foreach (Video video in new List<Video> { v1, v2, v3 })
            {
                foreach (string Comments in video.Comments)
                {
                    Console.WriteLine(Comments);
                }
            }
        
    }
}