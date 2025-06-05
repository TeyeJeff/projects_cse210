using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }

    public void AddComment(string commentersName, string commentText)
    {
        _comments.Add(new Comment(commentersName, commentText));

    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

}