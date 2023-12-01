using System;
using System.Globalization;
using System.Net;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<string> Comments = new List<string>();
            Comments.Add("First");
            Comments.Add("Wow this product that is advertised is amazing!");
            Comments.Add("I would not purchase the product being advertised.");
            Comments.Add("Cool video");
        List<string> names = new List<string>();
            names.Add("Dominic");
            names.Add("Julio");
            names.Add("Andrew");
            names.Add("Michael");
        List<string> authors = new List<string>();
            authors.Add("Fred");
            authors.Add("Steve");
            authors.Add("Warren");
            authors.Add("Steve");
        List<string> titles = new List<string>();
            titles.Add("How to video");
            titles.Add("Tutorial video");
            titles.Add("Cool coding trick video");
            titles.Add("Cat video");
        List<int> lengths = new List<int>();
            lengths.Add(152);
            lengths.Add(73);
            lengths.Add(95);
            lengths.Add(143);
        List<Video> videos = new List<Video>();
        
        for (int i = 0; i<4; i++) {
            List<Comment> comments = new List<Comment>();
            Random num = new Random();
            int numComments = num.Next(3,5);

            for (int j = 0; j<numComments; j++) {
                int rnd = num.Next(0,4);
                string commentText = Comments[rnd];
                string name = names[j];

                Comment comment = new Comment(name, commentText);
                comments.Add(comment);
            }
            
            string videoAuthor = authors[i];
            string title = titles[i];
            int length = lengths[i];

            Video video = new Video(title, videoAuthor, length, comments);
            videos.Add(video);
        }
        
        int k = 0;
        foreach (Video video in videos) {
            k++;
            string title = video.GetTitle(); 
            string videoAuthor = video.GetAuthor();
            int length = video.GetLength();
            int numComments = video.ReturnComments();
            List<Comment> videoComments = new List<Comment>();
            videoComments = video.GetComments();
            
            System.Console.WriteLine($"\nVideo {k} \nTitle: {title}\nVideo author: {videoAuthor} \nLength: {length} seconds \nNumber of comments: {numComments} \nComments:");
            foreach (Comment comment in videoComments) {
                string commentText = comment.GetText();
                System.Console.WriteLine($"\t{commentText}");
            }
        }
    }
}