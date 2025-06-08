using System;


public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetTextBookSection()
    {
        return _textbookSection;
    }

    public void SetTextBookSection(string textBookSection)
    {
        this._textbookSection = textBookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        this._problems = problems;
    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        this._textbookSection = textBookSection;
        this._problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"{GetStudentName()} - {GetTopic()} \n Section- {_textbookSection}, Problems- {_problems} "; 
    }


}