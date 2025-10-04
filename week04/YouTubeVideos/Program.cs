using System;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int Helpful = 4;

        while (Helpful != 0)
        {

            RNGMachine rng1 = new RNGMachine();

            string title = rng1.RandomTitle();
            string videoauthor = rng1.RandomAuthor();
            int length = rng1.RandomLength();
            int number1 = rng1.RandomNumber();

            Video vid1 = new Video(title, videoauthor, length);

            while (number1 != 0)
            {
                string comment = rng1.RandomComment();
                string commentauthor = rng1.RandomAuthor();
                Comment comment1 = new Comment(commentauthor, comment);
                number1 -= 1;
            }

            Comment comment2 = new Comment();
            List<string> commentlist = comment2.GetCommentList();
            vid1.SetCommentList(commentlist);
            vid1.DataMatching();

            Helpful -= 1;
        }

        Video vid2 = new Video();
        vid2.DisplayVideoList();
    }
}