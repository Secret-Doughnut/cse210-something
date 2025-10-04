public class Video
{
    private static List<string> VideoList = new List<string>();
    private static List<string> CommentList = new List<string>();

    private string _VideoTitle = "";
    private string _VideoAuthor = "";
    private int _VideoLength = 0;

    public Video()
    {

    }

    public Video(string title, string author, int length)
    {
        _VideoTitle = title;
        _VideoAuthor = author;
        _VideoLength = length;
    }

    private int CommentCounter()
    {
        int count = CommentList.Count();
        return count;
    }

    public void DataMatching()
    {
        string FullVideo = $"Author: {_VideoAuthor}: \nTitle: {_VideoTitle} \nVideo length in seconds: {_VideoLength}";
        string AllComments = "";

        int count = CommentCounter();

        foreach (string item in CommentList)
        {
            AllComments += $"\n{item}\n";
        }

        string CompleteVideo = $"{FullVideo}\n\nComment Count: {count}\n {AllComments}";

        VideoList.Add(CompleteVideo);
        CommentList.Clear();

    }

    public void SetCommentList(List<string> data)
    {
        CommentList = data;
    }

    public void DisplayVideoList()
    {
        int VideoCount = 1;

        foreach (string item in VideoList)
        {
            Console.WriteLine($"**Video #{VideoCount}**");
            Console.WriteLine(item);
            VideoCount += 1;
        }
    }
}