using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(string username, string text)
    {
        Comment newComment = new Comment(username, text);
        _comments.Add(newComment);
    }

    public string GetTimeStamp()
    {
        string timeStamp = ((_length / 60).ToString() + ":" +(_length % 60).ToString());
        return timeStamp;
    }

    public void Display()
    {
        Console.WriteLine(" ________________________________________________________");
        Console.WriteLine("|                                                        |");
        Console.WriteLine("|                                                        |");
        Console.WriteLine("|                         [►]  [■]                       |");
        Console.WriteLine("|                                                        |");
        Console.WriteLine("|________________________________________________________|");
        Console.WriteLine("|::::::::::::::::::||                                    |");
        Console.WriteLine($"|Title: {_title} | by:{_author} | {GetTimeStamp()}  |");
        Console.WriteLine("|________________________________________________________|");
        
        Console.WriteLine($"\n{_comments.Count} Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}