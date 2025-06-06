using System;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string text;
        if (this._endVerse == 0)
        {
            text = $"{_book} {_chapter}:{_verse}";

        }
        else
        {
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return text;
    }
    
    
        

        

        
    

}
