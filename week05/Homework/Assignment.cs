using System;


public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public Assignment(string studentName, string topic)
    {
        this._topic = topic;
        this._studentName = studentName;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }


}