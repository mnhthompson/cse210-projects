using System;

public class Comment
{
    private string _username;
    private string _commenttext;
    public Comment(string username, string commenttext)
    {
        _username = username;
        _commenttext = commenttext;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"< {_username} > {_commenttext}");
    }
}