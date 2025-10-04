public class Comment
{
    private static List<string> CommentList = new List<string>();

    private string _CommentAuthor = "";
    private string _CommentText = "";

    public Comment()
    {

    }

    public Comment(string author, string text)
    {
        _CommentAuthor = author;
        _CommentText = text;
        CommentListMaker();
    }

    private void CommentListMaker()
    {
        string FullComment = $"{_CommentAuthor}: {_CommentText}";
        CommentList.Add(FullComment);
    }

    public List<string> GetCommentList()
    {
        return CommentList;
    }
}