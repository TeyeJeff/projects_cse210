using System;


public class WritingAssignment : Assignment
{
    private string _title;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        this._title = title;
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this._title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic} \n {_title}";
    }
}